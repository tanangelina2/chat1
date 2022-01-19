using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace independent_learning
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        //byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }


        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                //check if theres actually information
                if (size>0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;
                    //Converting byte[] to string
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    //Adding this message into Listbox
                    listMessage.Items.Add("Luna Staff:" + receivedMessage);
                }
                //starts to listen to the socket again
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref
               epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void buttonConnect_Click_1(object sender, EventArgs e)
        {
            try
            {
                //binding socket
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text),
                    Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);

                //Connecting to remote IP
                epRemote = new
                IPEndPoint(IPAddress.Parse(textRemoteIp.Text),
                Convert.ToInt32(textRemotePort.Text));
                sck.Connect(epRemote);

                //Listening the specific port
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref
               epRemote, new AsyncCallback(MessageCallBack), buffer);

                //release button to send message
                buttonSend.Enabled = true;
                buttonConnect.Text = "Connected";
                buttonConnect.Enabled = false;
                textMessage.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            buttonConnect.Focus();
            //set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
           ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket,
           SocketOptionName.ReuseAddress, true);
            //get user IP
            textLocalIp.Text = GetLocalIP();
            textRemoteIp.Text = GetLocalIP();
            textLocalPort.Text = "100";
            textRemotePort.Text = "101";
            
        }

        private void buttonSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Convert string message to byte[]
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textMessage.Text);
                //Sending the Encoded message
                sck.Send(msg);
                //adding to the listbox
                listMessage.Items.Add("Me:" + textMessage.Text);
                textMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

    }
}

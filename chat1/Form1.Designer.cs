﻿
namespace independent_learning
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.textRemoteIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(66, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Me";
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(141, 87);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.ReadOnly = true;
            this.textLocalPort.Size = new System.Drawing.Size(100, 31);
            this.textLocalPort.TabIndex = 3;
            // 
            // textLocalIp
            // 
            this.textLocalIp.Location = new System.Drawing.Point(141, 37);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.ReadOnly = true;
            this.textLocalIp.Size = new System.Drawing.Size(169, 31);
            this.textLocalIp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textRemotePort);
            this.groupBox2.Controls.Add(this.textRemoteIp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(504, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Luna Staff";
            // 
            // textRemotePort
            // 
            this.textRemotePort.Location = new System.Drawing.Point(157, 84);
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.ReadOnly = true;
            this.textRemotePort.Size = new System.Drawing.Size(100, 31);
            this.textRemotePort.TabIndex = 7;
            // 
            // textRemoteIp
            // 
            this.textRemoteIp.Location = new System.Drawing.Point(157, 34);
            this.textRemoteIp.Name = "textRemoteIp";
            this.textRemoteIp.ReadOnly = true;
            this.textRemoteIp.Size = new System.Drawing.Size(170, 31);
            this.textRemoteIp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "IP";
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 25;
            this.listMessage.Location = new System.Drawing.Point(66, 257);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(900, 329);
            this.listMessage.TabIndex = 2;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(66, 650);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(740, 31);
            this.textMessage.TabIndex = 3;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(883, 134);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(154, 63);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click_1);
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(858, 642);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(91, 46);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 759);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textRemotePort;
        private System.Windows.Forms.TextBox textRemoteIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonSend;
    }
}


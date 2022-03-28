﻿using System;
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
using System.Threading;

namespace _0328
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UdpClient U;
        Thread Th;

        private void Listen()
        {
            int Port = int.Parse(textBox_listenPort.Text);
            U = new UdpClient(Port);
            IPEndPoint EP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Port);

            while (true)
            {
                byte[] B = U.Receive(ref EP);
                textBox_receiveMsg.Text = Encoding.Default.GetString(B);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "我的ip：" + MyIP();
               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Th = new Thread(Listen);

            Th.Start();

            button_startListen.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Th.Abort();
                U.Close();
            }
            catch
            { 
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string IP = textBox_targetIP.Text;
            int Port = int.Parse(textBox_targetPort.Text);
            byte[] B = Encoding.Default.GetBytes(textBox_sendMsg.Text);
            UdpClient S = new UdpClient();
            S.Send(B, B.Length, IP, Port);
            S.Close();
                
        }

        private string MyIP()
        {
            string hostname = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostEntry(hostname).AddressList;

            foreach (IPAddress it in ip)
            {
                if (it.AddressFamily == AddressFamily.InterNetwork && it.ToString()!= "192.168.56.1")
                {
                    return it.ToString();
                }

            }
            return "";
        }
    }
}

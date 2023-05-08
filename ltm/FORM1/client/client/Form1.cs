using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace client
{
    public partial class Form1 : Form
    {
        IPEndPoint iep;
        Socket server;
        Socket client;
        bool thoat = false;
        public Form1()
        {
            InitializeComponent();
        }
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                try { this.Invoke(new Action<string>(AppendTextBox), new object[] { value }); }
                catch (Exception) { }
                return;
            }
            KQ.Text += value+Environment.NewLine;
        }
        private void ThreadTask()
        {
            byte[] data = new byte[1024];
            int recv = client.Receive(data);
            string s = Encoding.ASCII.GetString(data, 0, recv);
            //Console.WriteLine("Server  gui:{0}", s);
            AppendTextBox("Server  gui:" + s);
            
            while (!thoat)
            {
                
                data = new byte[1024];
                recv = client.Receive(data);
                s = Encoding.ASCII.GetString(data, 0, recv);
                //Console.WriteLine("Server  gui:{0}", s);
                AppendTextBox("Server  gui:" + s);
            }
            client.Disconnect(true);
            client.Close();
            
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            iep = new IPEndPoint(IPAddress.Parse(IP.Text), int.Parse(PORT.Text));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);
            client.Connect(iep);
            Thread trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            trd.Start();

        }

        private void Send_Click(object sender, EventArgs e)
        {
            string input = message.Text;
            //Chuyen  input  thanh  mang  byte  gui  len  cho  server  
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(input);
            client.Send(data, data.Length, SocketFlags.None);
            if (input.ToUpper().Equals("QUIT"))
            {
                thoat = true;
                Close();
            }
                
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Serialization;
using MESSAGE;
namespace client
{
    public partial class Form1 : Form
    {
        IPEndPoint iep;
        Socket server;
        Socket client;
        bool thoat = false;
        Thread trd;
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
        private void sendJson(object obj)
        {
            byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj);
            client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
        }
        private void ThreadTask()
        {
            byte[] data = new byte[1024];
            MESSAGE.LOGIN login = new MESSAGE.LOGIN(UserName.Text, Pass.Text);
            
            string jsonString = JsonSerializer.Serialize(login);
            
            MESSAGE.COMMON common = new MESSAGE.COMMON(1, jsonString);            
            sendJson(common);            
            int recv = client.Receive(data);
            
            jsonString = Encoding.ASCII.GetString(data, 0, recv);
            jsonString.Replace("\\u0022", "\"");
            MESSAGE.COMMON? com =JsonSerializer.Deserialize<MESSAGE.COMMON>(jsonString);

            if (com!=null && com.kind == 3) {
                if (com.content == "OK")
                {
                    while (!thoat)
                    {
                        data = new byte[1024];
                        recv = client.Receive(data);
                        
                        jsonString = Encoding.ASCII.GetString(data, 0, recv);
                        //jsonString=jsonString.Replace("\\u0022", "\"");
                        jsonString = jsonString.Replace("\0", "");
                        com = JsonSerializer.Deserialize<MESSAGE.COMMON>(jsonString);

                        if (com != null && com.kind == 2)
                        {
                            MESSAGE.MESSAGE? mes= JsonSerializer.Deserialize<MESSAGE.MESSAGE>(com.content);
                            AppendTextBox(mes.usernameSender+":"+mes.content);
                        }
                        
                    }
                }
            }
            client.Disconnect(true);
            client.Close();
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            iep = new IPEndPoint(IPAddress.Parse(IP.Text), int.Parse(PORT.Text));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);
            client.Connect(iep);
            trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            trd.Start();

        }

        private void Send_Click(object sender, EventArgs e)
        {

            MESSAGE.MESSAGE mes = new MESSAGE.MESSAGE(UserName.Text, receiver.Text, message.Text);
            //var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(mes);
            MESSAGE.COMMON common = new MESSAGE.COMMON(2, jsonString);
            sendJson(common);

            
            if (message.Text.ToUpper().Equals("QUIT"))
            {
                thoat = true;
                Close();
            }
                
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
                if (trd != null)
                    trd.Abort();
            }
            catch (Exception)
            {

            }
            
            thoat = true;
        }
    }
}
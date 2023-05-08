using System.Net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
namespace server
{
    public partial class Form1 : Form
    {
        IPEndPoint iep ;
        Socket server ;
        Socket client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName(); 
            // Retrive the Name of HOST
            // Console.WriteLine(hostName);
            // Get the IP
            foreach(IPAddress ip in Dns.GetHostByName(hostName).AddressList)
            {
                if(ip.ToString().Contains("."))
                {
                    IP.Text = ip.ToString();
                    break;
                }
            }
            //string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            //IP.Text = myIP;
            //Console.WriteLine("My IP Address is :" + myIP);
            //Console.ReadKey();
        }
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            KQ.Text += value;
        }
        private void ThreadTask()
        {
            client = server.Accept();
            //Console.WriteLine("Chap  nhan  ket  noi  tu:{0}", client.RemoteEndPoint.ToString());
            //KQ.Text += "Chap  nhan  ket  noi  tu:" + client.RemoteEndPoint.ToString() + Environment.NewLine;
            
            AppendTextBox("Chap  nhan  ket  noi  tu:" + client.RemoteEndPoint.ToString() + Environment.NewLine);
            
            string s = "Chao  ban  den  voi  Server";
            //Chuyen  chuoi  s  thanh  mang  byte  
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(s);
            //gui  nhan  du  lieu  theo  giao  thuc  da  thiet  ke  
            client.Send(data, data.Length, SocketFlags.None);
            while (true)
            {
                data = new byte[1024];
                int recv = client.Receive(data);
                if (recv == 0) break;
                //Chuyen  mang  byte  Data  thanh  chuoi  va  in  ra  man  hinh  
                s = Encoding.ASCII.GetString(data, 0, recv);
                //Console.WriteLine("Clien  gui  len:{0}", s);
                AppendTextBox("Clien  gui  len:" + s + Environment.NewLine);
                //Neu  chuoi  nhan  duoc  la  Quit  thi  thoat  
                if (s.ToUpper().Equals("QUIT")) break;
                //Gui  tra  lai  cho  client  chuoi  s  
                s = s.ToUpper();
                data = new byte[1024];
                data = Encoding.ASCII.GetBytes(s);
                client.Send(data, data.Length, SocketFlags.None);
            }
            client.Shutdown(SocketShutdown.Both);
            client.Close();
            server.Close();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            iep = new IPEndPoint(IPAddress.Parse(IP.Text), int.Parse(PORT.Text));
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);
            server.Bind(iep);
            server.Listen(10);
            //Console.WriteLine("Cho  ket  noi  tu  client");
            KQ.Text += "Cho  ket  noi  tu  client" + Environment.NewLine;
            
            
            Thread trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            trd.Start();
        }
    }
}
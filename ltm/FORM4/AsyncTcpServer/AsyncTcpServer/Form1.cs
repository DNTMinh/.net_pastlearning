using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AsyncTcpServer
{
    public partial class Form1 : Form
    {
        IPEndPoint iep;

        private byte[] data = new byte[1024];
        private Socket Server;
        private ListBox results;

        public Form1()
        {
            InitializeComponent();
            StopServer.Click += new EventHandler(ButtonStopOnClick);
            StartServer.Click += new EventHandler(ButtonStartOnClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            //Console.WriteLine(hostName);
            //Get the IP
            foreach (IPAddress ip in Dns.GetHostByName(hostName).AddressList)
            {
                if (ip.ToString().Contains("."))
                {
                    iptext.Text = ip.ToString();
                    break;
                }
            }
        }

        private delegate void SafeCallDelegate(string text);

        private void WriteTextSafe(string text)
        {
            if (Txtbox.InvokeRequired)
            {
                Txtbox.Invoke(new SafeCallDelegate(WriteTextSafe), text);
            }
            else
            {
                Txtbox.Text += text + "\r\n";
            }
        }

        void AcceptConn(IAsyncResult iar)
        {
            Socket oldserver = (Socket)iar.AsyncState;
            Socket client = oldserver.EndAccept(iar);
            var Text = "Connected to: " + client.RemoteEndPoint.ToString();
            WriteTextSafe(Text);
            string s = "Welcome to my server";
            byte[] mess = Encoding.ASCII.GetBytes(s);
            client.BeginSend(mess, 0, mess.Length, SocketFlags.None, new AsyncCallback(SendData), client);
    }
        void SendData(IAsyncResult iar)
        {
            Socket client = (Socket)iar.AsyncState;
            int sent = client.EndSend(iar);
            client.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(ReceiveData), client);

        }

        void ReceiveData(IAsyncResult iar)
        {
            Socket client = (Socket)iar.AsyncState;
            int recv = client.EndReceive(iar);
            if (recv == 0)
            {
                client.Close();
                var Text = "Waiting for client...";
                WriteTextSafe(Text);
                Server.BeginAccept(new AsyncCallback(AcceptConn), Server);
                return;
            }
            string recvData = Encoding.ASCII.GetString(data, 0, recv);
            var Text2 = "Client :" + recvData;
            WriteTextSafe(Text2);
            //List<string> result = new List<string>();
            WriteTextSafe(recvData);
            byte[] mess = Encoding.ASCII.GetBytes(recvData);
            client.BeginSend(mess, 0, mess.Length, SocketFlags.None, new AsyncCallback(SendData), client);
        }

        private void ButtonStartOnClick(object obj, EventArgs ea)
        {
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            iep = new IPEndPoint(IPAddress.Parse(iptext.Text), int.Parse(porttext.Text));
            Server.Bind(iep);
            Server.Listen(5);
            Server.BeginAccept(new AsyncCallback(AcceptConn), Server);
            Txtbox.Text = "Cho ket noi den client!";
        }

        private void ButtonStopOnClick(object obj, EventArgs ea)
        {
            Close();
        }
    }
}
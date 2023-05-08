using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AsyncTcpClient
{
    public partial class client : Form
    {
        IPEndPoint iep;
        private ListBox results;
        private Socket Client;
        private byte[] data = new byte[1024];
        private int size = 1024;

        public client()
        {
            InitializeComponent();
            connect.Click += new EventHandler(ButtonConnectOnClick);
            discon.Click += new EventHandler(ButtonDisconOnClick);
            sendit.Click += new EventHandler(ButtonSendOnClick);
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

        private void Connect_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void Connected(IAsyncResult iar)
        {
            Client = (Socket)iar.AsyncState;
            try
            {
                Client.EndConnect(iar);
                var Text = "Connected to:" + Client.RemoteEndPoint.ToString();
                WriteTextSafe(Text);
                Client.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(ReceiveData), Client);
            }
            catch (Exception)
            {
                var Text = "Error connecting";
                WriteTextSafe(Text);
            }
            
        }

        void SendData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int sent = remote.EndSend(iar);
            remote.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(ReceiveData), remote);
        }

        void ReceiveData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int recv = remote.EndReceive(iar);
            string s = Encoding.ASCII.GetString(data, 0, recv);
            WriteTextSafe(s);
        }

        private void ButtonConnectOnClick(object obj, EventArgs ea)
        {
            Text = "Connecting...";
            WriteTextSafe(Text);
            iep = new IPEndPoint(IPAddress.Parse(iptext.Text), int.Parse(porttext.Text));
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            newsock.BeginConnect(iep, new AsyncCallback(Connected), newsock);
        }

        private void ButtonSendOnClick(object obj, EventArgs ea)
        {
            byte[] message = Encoding.ASCII.GetBytes(textBox2.Text);
            Text = textBox2.Text;
            WriteTextSafe(Text);
            textBox2.Clear();
            Client.BeginSend(message, 0, message.Length, SocketFlags.None, new AsyncCallback(SendData), Client);
        }

        private void ButtonDisconOnClick(object obj, EventArgs ea)
        {
            Client.Close();
            Txtbox.Text = "Disconnected";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
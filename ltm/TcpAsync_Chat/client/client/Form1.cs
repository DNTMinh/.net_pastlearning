using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using Class;

namespace client
{
    public partial class Form1 : Form
    {
        private delegate void CallDelegate(string text);
        private Socket client;
        private byte[] data = new byte[1024];
        private bool isConnected = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP.Text), int.Parse(PORT.Text));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.BeginConnect(iep, new AsyncCallback(ConnectCallback), null);
        }
        private void ConnectCallback(IAsyncResult iar)
        {
            try
            {
                client.EndConnect(iar);
                SetText("Connected to: " + client.RemoteEndPoint.ToString());
                isConnected = true;
                ReceiveData(client);
            }
            catch (SocketException)
            {
            }
        }

        private void SendData(Socket socket, object obj)
        {
            string json = ParseToJson(obj);
            byte[] message1 = Encoding.ASCII.GetBytes(json);
            socket.BeginSend(message1, 0, message1.Length, SocketFlags.None, new AsyncCallback(SendDataCallback), socket);
        }
        private void SendDataCallback(IAsyncResult iar)
        {
            Socket socket = (Socket)iar.AsyncState;
            int sent = socket.EndSend(iar);
            ReceiveData(socket);
        }

        private void ReceiveData(Socket socket)
        {
            socket.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ThreadTask), socket);
        }
        private void ThreadTask(IAsyncResult iar)
        {
            try
            {
                Socket remote = (Socket)iar.AsyncState;
                int recv = remote.EndReceive(iar);
                string json = Encoding.ASCII.GetString(data, 0, recv);
                Common conn = JsonSerializer.Deserialize<Common>(json);

                if (conn != null)
                {
                    switch (conn.Kind)
                    {
                        case "LOGOUT":
                            {
                                Response response = JsonSerializer.Deserialize<Response>(conn.Content);
                                MessageBox.Show(response.Content);
                                BeginInvoke(new MethodInvoker(() => Close()));
                            }
                            break;
                        case "CHAT":
                            {
                                Chat msg = JsonSerializer.Deserialize<Chat>(conn.Content);
                                string sender = msg.Sender;
                                string content = msg.Content;

                                if (sender != null && content != null)
                                {
                                    SetText($"{sender}: {content}");
                                    break;
                                }
                            }
                            break;
                        default:
                            {
                                Response res = JsonSerializer.Deserialize<Response>(conn.Content);
                                MessageBox.Show(res.Content);
                            }
                            break;
                    }
                }

                ReceiveData(client);
            }
            catch (Exception)
            {
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                string username = txtUsername.Text;
                string receiver = txtReceiver.Text;
                string message = txtMessage.Text;

                if (username != null && receiver != null && message != null)
                {
                    Chat chat = new Chat(username, receiver, message);
                    Common common = new Common("CHAT", ParseToJson(chat));
                    SendData(client, common);
                    ReceiveData(client);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if (username != null && password != null)
                {
                    Login userInfo = new Login(username, password);
                    Common common = new Common("REGISTER", ParseToJson(userInfo));
                    SendData(client, common);
                    ReceiveData(client);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if (username != null && password != null)
                {
                    Login userInfo = new Login(username, password);
                    Common common = new Common("LOGIN", ParseToJson(userInfo));
                    SendData(client, common);
                    ReceiveData(client);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                string username = txtUsername.Text;

                if (username != null)
                {
                    Logout logout = new Logout(username);
                    Common common = new Common("LOGOUT", ParseToJson(logout));
                    SendData(client, common);
                    ReceiveData(client);
                }
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                string groupName = txtGroupName.Text;
                string memberName = txtMemberName.Text;

                if (groupName != null && memberName != null)
                {
                    Group group = new Group(groupName, memberName);
                    Common common = new Common("GROUP", ParseToJson(group));
                    SendData(client, common);
                    ReceiveData(client);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isConnected)
            {
                string username = txtUsername.Text;

                if (username != null)
                {
                    Logout logout = new Logout(username);
                    Common common = new Common("LOGOUT", ParseToJson(logout));
                    SendData(client, common);
                    ReceiveData(client);
                }
            }
        }

        private void SetText(string text)
        {
            if (KQ.InvokeRequired)
            {
                var dlg = new CallDelegate(SetText);
                KQ.Invoke(dlg, new object[] { text });
            }
            else
            {
                KQ.Text += text + Environment.NewLine;
                KQ.SelectionStart = KQ.TextLength;
                KQ.ScrollToCaret();
            }
        }

        private string ParseToJson(object obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}
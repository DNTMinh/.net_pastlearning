using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Class;

namespace Server
{
    public partial class Form1 : Form
    {
        private delegate void CallDelegate(string text);
        Socket server;
        Dictionary<string, string> DSAccount = new Dictionary<string, string>(); // "username": "password"
        Dictionary<string, Socket> DSClient = new Dictionary<string, Socket>(); // "username": Socket
        Dictionary<string, List<string>> DSGroup = new Dictionary<string, List<string>>(); // "groupname": List["username"]
        private byte[] data = new byte[1024];
        private int size = 1024;

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP.Text), int.Parse(PORT.Text));
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(iep);
            server.Listen(10);
            server.BeginAccept(new AsyncCallback(AcceptClientThread), null);
        }

        private void AcceptClientThread(IAsyncResult iar)
        {
            try
            {
                Socket client = server.EndAccept(iar);

                server.BeginAccept(new AsyncCallback(AcceptClientThread), null);

                SetText("Connected from: " + client.RemoteEndPoint.ToString());

                Response res = new Response("Welcome to server");
                Common common = new Common("OK", ParseToJson(res));
                SendData(client, common);
                ReceiveData(client);
            }
            catch (Exception)
            {
            }
        }

        private void SendData(Socket client, object obj)
        {
            string json = ParseToJson(obj);
            byte[] message1 = Encoding.ASCII.GetBytes(json);
            client.BeginSend(message1, 0, message1.Length, SocketFlags.None, new AsyncCallback(SendDataCallback), client);
        }
        private void SendDataCallback(IAsyncResult iar)
        {
            Socket client = (Socket)iar.AsyncState;
            int sent = client.EndSend(iar);
        }

        private void ReceiveData(Socket client)
        {
            client.BeginReceive(data, 0, size, SocketFlags.None, new AsyncCallback(handleClient), client);
        }

        private void handleClient(IAsyncResult iar)
        {
            try
            {
                Socket client = (Socket)iar.AsyncState;
                int recv = client.EndReceive(iar);
                string jsonString = Encoding.ASCII.GetString(data, 0, recv);
                Common conn = JsonSerializer.Deserialize<Common>(jsonString);

                if (conn != null && conn.Content != null)
                {
                    switch (conn.Kind)
                    {
                        case "LOGIN":
                            {
                                Login userInfo = JsonSerializer.Deserialize<Login>(conn.Content);
                                string username = userInfo.Username;
                                string password = userInfo.Password;

                                if (DSAccount.ContainsKey(username) && DSAccount[username] == password)
                                {

                                    DSClient.Remove(username);
                                    DSClient.Add(username, client);

                                    ResponseToClient(client, "OK", "Login succeed!");
                                    ReceiveData(client);
                                    SetText($"{username} logged in!");
                                }
                                else
                                {
                                    ResponseToClient(client, "CANCEL", "Login failed!");
                                    ReceiveData(client);
                                }
                            }
                            break;
                        case "REGISTER":
                            {
                                Login registerInfo = JsonSerializer.Deserialize<Login>(conn.Content);
                                string username = registerInfo.Username;
                                string password = registerInfo.Password;

                                if (DSAccount.ContainsKey(username))
                                {
                                    ResponseToClient(client, "CANCEL", "Account has already existed!");
                                    SetText($"{username} registered!");
                                }
                                else
                                {
                                    DSAccount.Add(username, password);
                                    ResponseToClient(client, "OK", "Account was successfully created!");
                                }
                            }
                            break;
                        case "LOGOUT":
                            {
                                Logout logout = JsonSerializer.Deserialize<Logout>(conn.Content);
                                string username = logout.Username;
                                if (DSClient.ContainsKey(username))
                                {
                                    ResponseToClient(client, "LOGOUT", "Successfully logged out!");
                                    DSClient.Remove(username);
                                    SetText($"{username} logged out!");
                                }
                            }
                            break;
                        case "CHAT":
                            Chat msg = JsonSerializer.Deserialize<Chat>(conn.Content);
                            string sender = msg.Sender;
                            string receiver = msg.Receiver;
                            string content = msg.Content;

                            if (sender != null && receiver != null && content != null)
                            {
                                bool equal = DSClient.ContainsKey(receiver);
                                if (DSClient.ContainsKey(receiver))
                                {
                                    SetText($"{sender} gui {receiver}: {content + Environment.NewLine}");
                                    Socket friend = DSClient[receiver];
                                    SendData(friend, conn);
                                    break;
                                }
                                if (DSGroup.ContainsKey(receiver))
                                {
                                    foreach (string user in DSGroup[receiver])
                                    {
                                        if (DSClient.ContainsKey(user))
                                        {
                                            Socket friend = DSClient[user];
                                            SendData(friend, conn);
                                        }
                                    }
                                    SetText($"{sender} send to {receiver}: {content + Environment.NewLine}");
                                    break;
                                }
                            }
                            break;
                        case "GROUP":
                            Group group = JsonSerializer.Deserialize<Group>(conn.Content);
                            string groupName = group.GroupName;
                            string memberName = group.MemberName;

                            if (DSGroup.ContainsKey(groupName))
                            {
                                if (DSGroup[groupName].Contains(memberName))
                                {
                                    ResponseToClient(client, "CANCEL", "Member has already existed in group!");
                                }
                                else
                                {
                                    DSGroup[groupName].Add(memberName);
                                    ResponseToClient(client, "OK", "Successfully added!");
                                    SetText($"{memberName} was added to {groupName}!");
                                }
                            }
                            else
                            {
                                DSGroup.Add(groupName, new List<string>() { memberName });
                                ResponseToClient(client, "OK", "Group was successfully added");
                                SetText($"{groupName} was added!");
                            }
                            break;
                        default:
                            break;
                    }
                }

                ReceiveData(client);
            }
            catch (Exception)
            {
            }
        }

        private void AddUser()
        {
            for (int i = 1; i < 11; i++)
            {
                char letter = (char)('A' + (char)((i - 1) % 26));
                DSAccount.Add($"{letter}", "123");
            }
        }

        private void AddGroup()
        {
            int length = DSAccount.Count();
            int groupIndex = 0;
            string groupName = $"Group{groupIndex}";
            DSGroup.Add(groupName, new List<string>());

            for (int i = 0; i < length; i++)
            {
                if (i != 0 && i % 3 == 0)
                {
                    groupIndex += 1;
                    groupName = $"Group{groupIndex}";
                    DSGroup.Add(groupName, new List<string>());
                }
                DSGroup[groupName].Add(DSAccount.ElementAt(i).Key);
            }
        }

        private void ResponseToClient(Socket client, string statusCode, string message)
        {
            Response res = new Response(message);
            Common common = new Common(statusCode, ParseToJson(res));
            SendData(client, common);
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


        private void Form1_Load(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName();
            string myIP = "";
            IPAddress[] IPArray = Dns.GetHostByName(hostName).AddressList;
            foreach (IPAddress ip in IPArray)
            {
                if (ip.ToString().Contains('.'))
                {
                    myIP = ip.ToString();
                    break;
                }
            }
            IP.Text = myIP;

            AddUser();
            AddGroup();
        }
    }
}

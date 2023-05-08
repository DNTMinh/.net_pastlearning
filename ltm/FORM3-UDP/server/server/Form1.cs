using System.Net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Serialization;
using MESSAGE;
namespace server
{
    public partial class Form1 : Form
    {
        IPEndPoint iep ;

        Socket server ;
        Dictionary<string, string> DS;
        Dictionary<string, List<string>> DSNhom;
        //Dictionary<string, Socket> DSClient;
        Dictionary<string, EndPoint> DSClient;

        bool active = false;
        private void KhoiTaoUser()
        {
            DS = new Dictionary<string, string>();
            DSNhom = new Dictionary<string, List<string>>();
            char u;
            for(u='A';u<'Z';u++)
                DS.Add(u.ToString(), "123");
            for(byte i = 0; i < 5; i++)
            {
                List<string> nhom = new List<string>();
                for(byte j = 0; j < 3; j++)
                {
                    u = (Char)('A'+3 * i + j);
                    nhom.Add(u.ToString());
                }
                DSNhom.Add("N"+i.ToString(), nhom);
            }
            DSClient = new Dictionary<string, EndPoint>();
        }
        public Form1()
        {
            InitializeComponent();
        }

        public void ChangeAttribute(Button btn, bool value)
        {
            btn.BeginInvoke(new MethodInvoker(() =>
            {
                btn.Enabled = value;
            }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            //Console.WriteLine(hostName);
            // Get the IP
            foreach(IPAddress ip in Dns.GetHostByName(hostName).AddressList)
            {
                if(ip.ToString().Contains("."))
                {
                    IP.Text = ip.ToString();
                    break;
                }
            }
            KhoiTaoUser();
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
        private  void sendJson(EndPoint client,object obj)
        {
            byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj);
            //client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
            server.SendTo(jsonUtf8Bytes, 0, jsonUtf8Bytes.Length, SocketFlags.None, client);
        }
        private void ThreadClient(byte[] data,int recv,EndPoint client)
        {
            //byte[] data = new byte[1024];
            //int recv = client.Receive(data);
            //int recv = server.ReceiveFrom(data,ref client);
            //if (recv == 0) return;
            String chuoi = Encoding.ASCII.GetString(data, 0, recv);
            string jsonString = chuoi;
            
            MESSAGE.COMMON? com = JsonSerializer.Deserialize<MESSAGE.COMMON>(jsonString);
            if (com!=null )
            {
                if(com.content!=null)
                {
                    switch (com.kind)
                    {
                        case 1:
                            { 
                            LOGIN? login = JsonSerializer.Deserialize<LOGIN>(com.content);
                            if (login != null && login.username != null && DS.Keys.Contains(login.username) && login.pass == DS[login.username])
                            {
                                com = new COMMON(3, "OK");
                                sendJson(client, com);
                                DSClient.Remove(login.username);
                                DSClient.Add(login.username, client);
                            }
                            else
                            {
                                com = new COMMON(3, "CANCEL");
                                sendJson(client, com);
                                return;
                            }
                            break;
                            }
                        case 5:
                            {
                                LOGIN? login = JsonSerializer.Deserialize<LOGIN>(com.content);
                                if (login != null && login.username != null && !DS.Keys.Contains(login.username))
                                {
                                    DS.Add(login.username, login.pass);
                                    com = new COMMON(3, "OK");
                                    sendJson(client, com);                                    
                                }
                                else
                                {
                                    com = new COMMON(3, "CANCEL");
                                    sendJson(client, com);
                                    return;
                                }
                            }
                            
                            break;
                        case 2:
                            MESSAGE.MESSAGE? mes = JsonSerializer.Deserialize<MESSAGE.MESSAGE>(com.content);
                            if (mes != null && mes.usernameReceiver != null)
                            {
                                if (DSClient.Keys.Contains(mes.usernameReceiver))
                                {
                                    AppendTextBox(mes.usernameSender + " send to " + mes.usernameReceiver + " content: " + mes.content + Environment.NewLine);
                                    //Socket friend = DSClient[mes.usernameReceiver];
                                    EndPoint friend = DSClient[mes.usernameReceiver];
                                    //friend.Send(data, recv, SocketFlags.None);                                    
                                    server.SendTo(data, 0, recv, SocketFlags.None, friend);
                                }
                                else//Nhom
                                {
                                    if (DSNhom.Keys.Contains(mes.usernameReceiver))
                                    {
                                        if (DSNhom[mes.usernameReceiver].Contains(mes.usernameSender))
                                        {
                                            AppendTextBox(mes.usernameSender + " send to " + mes.usernameReceiver + " content: " + mes.content + Environment.NewLine);
                                            foreach (String user in DSNhom[mes.usernameReceiver])
                                            {
                                                if (DSClient.Keys.Contains(user))
                                                {
                                                    EndPoint friend = DSClient[user];
                                                    //friend.Send(data, recv, SocketFlags.None);
                                                    server.SendTo(data, 0, recv, SocketFlags.None, friend);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            com = new COMMON(10, "CANCEL");
                                            sendJson(client, com);
                                        }
                                    }
                                    else
                                    {
                                        com = new COMMON(11, "CANCEL");
                                        sendJson(client, com);
                                    }

                                }
                            }
                            break;
                        case 4:
                            DSClient.Remove(com.content);                            
                            break;
                        case 6:
                            {

                                if (!DSNhom.Keys.Contains(com.content))
                                {
                                    DSNhom.Add(com.content, new List<string>());
                                    com = new COMMON(8, "OK");
                                    sendJson(client, com);
                                }
                                else
                                {
                                    com = new COMMON(8, "CANCEL");
                                    sendJson(client, com);
                                    //return;

                                }
                            }
                            break;
                        case 7:
                            {
                                MESSAGE.ADDNHOM? obj = JsonSerializer.Deserialize<MESSAGE.ADDNHOM>(com.content);
                                if (!DSNhom.Keys.Contains(obj.GrpName))
                                {
                                    com = new COMMON(9, "CANCEL");
                                    sendJson(client, com);
                                    return;

                                }
                                else
                                {
                                    foreach (var user in obj.members)
                                        if (!DS.Keys.Contains(user))
                                        {
                                            com = new COMMON(9, "CANCEL");
                                            sendJson(client, com);
                                            return;
                                        }
                                    foreach (var user in obj.members)
                                    {
                                        if (!DSNhom[obj.GrpName].Contains(user))
                                            DSNhom[obj.GrpName].Add(user);
                                    }

                                    //DSNhom.Add(com.content, new List<string>());
                                    com = new COMMON(9, "OK");
                                    sendJson(client, com);
                                }
                            }
                            break;
                    }
                    
                }
                else
                {
                    com = new COMMON(3, "CANCEL");
                    sendJson(client, com);                    
                    return;
                }                
            }
            

        }
        private void ThreadTask()
        {
            while (active)
            {
                try
                {
                    EndPoint client = new IPEndPoint(IPAddress.Any, 0);
                    byte[] data = new byte[1024];
                    int recv = server.ReceiveFrom(data, ref client);
                    ThreadClient(data, recv, client);
                }
                catch (Exception)
                {
                    active = false;
                }
                               
            }
        }
        private void Start_Click(object sender, EventArgs e)
        {
            active = true;
            //iep = new IPEndPoint(IPAddress.Parse(IP.Text), int.Parse(PORT.Text));
            //server = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);
            //server.Bind(iep);
            //server.Listen(10);

            iep = new IPEndPoint(IPAddress.Parse(IP.Text), int.Parse(PORT.Text)); 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); 
            server.Bind(iep); 
            //Console.WriteLine("Cho  ket  noi  tu  client");
            KQ.Text += "Cho  ket  noi  tu  client" + Environment.NewLine;
            
            
            Thread trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            trd.Start();

            ChangeAttribute(Start, false);
            ChangeAttribute(Stop, true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            active = false;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            ChangeAttribute(Start, true);
            ChangeAttribute(Stop, false);
        }
    }
}
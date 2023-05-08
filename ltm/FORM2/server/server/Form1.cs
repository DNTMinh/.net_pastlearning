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
        Dictionary<string, Socket> DSClient;
        bool active = false;
        private void KhoiTaoUser()
        {
            DS = new Dictionary<string, string>();
            DS.Add("A", "123");
            DS.Add("B", "123");
            DS.Add("C", "123");
            DS.Add("D", "123");
            DSClient = new Dictionary<string, Socket>();
        }
        public Form1()
        {
            InitializeComponent();
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
        private  void sendJson(Socket client,object obj)
        {
            byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj);
            client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
        }
        private void ThreadClient(Socket client)
        {            
            byte[] data = new byte[1024];
            int recv = client.Receive(data);
            if (recv == 0) return;
            string jsonString = Encoding.ASCII.GetString(data, 0, recv);
            
            MESSAGE.COMMON? com = JsonSerializer.Deserialize<MESSAGE.COMMON>(jsonString);
            if (com!=null )
            {
                if(com.kind ==1&& com.content!=null)
                {
                    LOGIN? login = JsonSerializer.Deserialize<LOGIN>(com.content);
                    if (login!=null && login.username!=null && login.pass == DS[login.username])
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
                }
                else
                {
                    com = new COMMON(3, "CANCEL");
                    sendJson(client, com);                    
                    return;
                }                
            }
            try
            {
                while (true)
                {
                    data = new byte[1024];
                    recv = client.Receive(data);
                    if (recv == 0) continue;
                    string s = Encoding.ASCII.GetString(data, 0, recv);

                    
                    if (s.ToUpper().Equals("QUIT")) break;
                    com = JsonSerializer.Deserialize<MESSAGE.COMMON>(s);
                    
                    if (com!=null&&com.kind == 2&&com.content!=null)
                    {
                        MESSAGE.MESSAGE? mes = JsonSerializer.Deserialize<MESSAGE.MESSAGE>(com.content);
                        if (mes!=null&&mes.usernameReceiver != null)
                        {
                            if(DSClient.Keys.Contains(mes.usernameReceiver))
                            {
                                AppendTextBox(mes.usernameSender+" send to "+mes.usernameReceiver +" content: " + mes.content + Environment.NewLine);
                                Socket friend = DSClient[mes.usernameReceiver];
                                friend.Send(data, data.Length, SocketFlags.None);
                            }
                            
                        }                        
                    }                                        
                }
                client.Shutdown(SocketShutdown.Both);
                client.Close();
                //server.Close();
            }
            catch (Exception)
            {
                //server.Close();
            }

        }
        private void ThreadTask()
        {
            while (active)
            {
                try
                {
                    Socket client = server.Accept();                   
                    var t = new Thread(() => ThreadClient(client));
                    t.Start();
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
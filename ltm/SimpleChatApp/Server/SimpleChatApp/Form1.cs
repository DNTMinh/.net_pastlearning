using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SimpleChatApp
{
    public partial class Server : Form
    {
        IPEndPoint iep;
        Socket server;

        private ConcurrentDictionary<long, MyClient> clients = new ConcurrentDictionary<long, MyClient>();

        private Thread disconnect = null;
        private bool active = false;
        private bool exit = false;

        private struct MyClient
        {
            public long id;
            public StringBuilder username;
            public TcpClient client;
            public NetworkStream stream;
            public byte[] buffer;
            public StringBuilder data;
            public EventWaitHandle handle;
        };

        public Server()
        {
            InitializeComponent();
        }

        private string SystemMsg(string msg)
        {
            return string.Format("SYSTEM: {0}", msg);
        }

        private string ErrorMsg(string msg)
        {
            return string.Format("ERROR: {0}", msg);
        }

        private void Server_Load(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            //Console.WriteLine(hostName);
            // Get the IP
            foreach (IPAddress ip in Dns.GetHostByName(hostName).AddressList)
            {
                if (ip.ToString().Contains("."))
                {
                    ipTxtBox.Text = ip.ToString();
                    break;
                }
            }
        }

        private void Active(bool status)
        {
            if (!exit)
            {
                startBtn.Invoke((MethodInvoker)delegate
                {
                    active = status;
                    if (status)
                    {
                        ipTxtBox.Enabled = false;
                        portTxtBox.Enabled = false;
                        startBtn.Text = "Stop";
                        Log(SystemMsg("Server has started"));
                    }
                    else
                    {
                        ipTxtBox.Enabled = true;
                        portTxtBox.Enabled = true;
                        startBtn.Text = "Start";
                        Log(SystemMsg("Server has stopped"));
                    }
                });
            }
        }

        private void AddToGrid(long id, string name)
        {
            if (!exit)
            {
                clientDataGridView.Invoke((MethodInvoker)delegate
                {
                    string[] row = new string[] { id.ToString(), name };
                    clientDataGridView.Rows.Add(row);
                    Total.Text = string.Format("Total clients: {0}", clientDataGridView.Rows.Count);
                });
            }
        }

        private void RemoveFromGrid(long id)
        {
            if (!exit)
            {
                clientDataGridView.Invoke((MethodInvoker)delegate
                {
                    foreach (DataGridViewRow row in clientDataGridView.Rows)
                    {
                        if (row.Cells["identifier"].Value.ToString() == id.ToString())
                        {
                            clientDataGridView.Rows.RemoveAt(row.Index);
                            break;
                        }
                    }
                    Total.Text = string.Format("Total clients: {0}", clientDataGridView.Rows.Count);
                });
            }
        }

        private void Log(string msg = "") // clear the log if message is not supplied or is empty
        {
            if (!exit)
            {
                logTxtBox.Invoke((MethodInvoker)delegate
                {
                    if (msg.Length > 0)
                    {
                        logTxtBox.AppendText(string.Format("[ {0} ] {1}{2}", DateTime.Now.ToString("HH:mm"), msg, Environment.NewLine));
                    }
                    else
                    {
                        logTxtBox.Clear();
                    }
                });
            }
        }

        private void Disconnect(long id = -1) // disconnect everyone if ID is not supplied or is lesser than zero
        {
            if (disconnect == null || !disconnect.IsAlive)
            {
                disconnect = new Thread(() =>
                {
                    if (id >= 0)
                    {
                        clients.TryGetValue(id, out MyClient obj);
                        obj.client.Close();
                        RemoveFromGrid(obj.id);
                    }
                    else
                    {
                        foreach (KeyValuePair<long, MyClient> obj in clients)
                        {
                            obj.Value.client.Close();
                            RemoveFromGrid(obj.Value.id);
                        }
                    }
                })
                {
                    IsBackground = true
                };
                disconnect.Start();
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (active)
            {
                active = false;
            }
            else
            {
                active = true;
                iep = new IPEndPoint(IPAddress.Parse(ipTxtBox.Text), int.Parse(portTxtBox.Text));
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Bind(iep);
                server.Listen(10);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Log();
        }

        private void disconClientBtn_Click(object sender, EventArgs e)
        {

        }
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            active = false;
        }
    }
}
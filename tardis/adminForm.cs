using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;

namespace tardis
{
    public partial class adminForm : Form
    {
       
        #region varijable
        RTBExtend box;
        private byte[] buffer = new byte[1024];
        public List<Sckt> ClientSockets { get; set; }
        List<string> names = new List<string>();
        private Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        #endregion
        private void startBtn_Click(object sender, EventArgs e)
        {
            if (startBtn.Text=="Start server")
            {
                startBtn.Enabled = false;
                replyBx.Enabled = true;
                sendBtn.Enabled = true;
           //     SetupServer();
            }
            else
            {
                box.AppendText("---------------Server je zaustavljen---------------", Color.Red);
                replyBx.Enabled = false;
                sendBtn.Enabled = false;
             }

        }

        private void SetupServer()
        {
            box.AppendText("---------------Server je pokrenut---------------", Color.Red);
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100));
            serverSocket.Listen(1);
            serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void AcceptCallback(IAsyncResult AR)
        {
            Socket socket = serverSocket.EndAccept(AR);
            ClientSockets.Add(new Sckt(socket));
            clientList.Items.Add(socket.RemoteEndPoint.ToString());

            clientCount.Text = "Trenutno povezanih klijenata: " + ClientSockets.Count.ToString();
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            if(socket.Connected)
            {
                int received;
                try
                {
                    received = socket.EndReceive(AR);
                }
                catch(Exception)
                {
                    for (int i=0; i<ClientSockets.Count;i++)
                    {
                        if(ClientSockets[i]._Socket.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            ClientSockets.RemoveAt(i);
                            clientCount.Text = "Trenutno povezanih klijenata: " + ClientSockets.Count.ToString();
                        }
                    }
                    return;
                }

                if(received!=0)
                {
                    byte[] dataBuffer = new byte[received];
                    Array.Copy(buffer, dataBuffer, received);
                    string text = Encoding.ASCII.GetString(dataBuffer);
                    box.AppendText(text, Color.Black);

                    string response = string.Empty;

                    for(int i=0;i<ClientSockets.Count;i++)
                    {
                        if (socket.RemoteEndPoint.ToString().Equals(ClientSockets[i]._Socket.RemoteEndPoint.ToString()))
                        {
                            box.AppendText(ClientSockets[i]._Name + ":" + text,Color.Black);
                        }
                    }
                    

                }
                else
                {
                    for(int i=0;i<ClientSockets.Count;i++)
                    {
                        if (ClientSockets[i]._Socket.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            ClientSockets.RemoveAt(i);
                            clientCount.Text = "Trenutno povezanih klijenata: " + ClientSockets.Count.ToString();
                        }
                    }
                }
            }
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
        }

        void SendData(Socket s, string txt)
        {
            byte[] data = Encoding.ASCII.GetBytes(txt);
            s.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), s);
            serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void SendCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }
        private void sendBtn_Click(object sender, EventArgs e)
        {
            if(replyBx.Text!="")
            {
                DateTime vrijeme = new DateTime();
                vrijeme = DateTime.Now;
                //Ukoliko nije napisana naredba onda se ispisuje sadrzaj replyBx-a
                if (naredbe(replyBx.Text.ToLower(), vrijeme))
                {
                    string textToSend = "Marko:" + "(" + vrijeme.ToLongTimeString() + "): " + replyBx.Text;
                    box.AppendText(textToSend, Color.Black);
                    for(int i=0;i<clientList.CheckedItems.Count;i++)
                    {
                        string t = clientList.CheckedItems[i].ToString();
                        for(int j=0;j<ClientSockets.Count;j++)
                        {
                            SendData(ClientSockets[j]._Socket, textToSend);
                        }
                    }
                }
                replyBx.Text = "";
            }
        }

        private bool naredbe(string text, DateTime vrijeme)
        {
            if (text == "/gettime")
            {
                box.AppendText("Trenutno vrijeme je: " + vrijeme.ToLongTimeString(), Color.Red);
                return false;
            }
            else if (text == "/getdate")
            {
                box.AppendText("Datum danas je: " + vrijeme.ToLongDateString(), Color.Red);
                return false;
            }
            else if (text == "/getdatetime")
            {
                box.AppendText("Datum danas je " + vrijeme.ToLongDateString() + "\n" + "Trentuno vrijeme je: " + vrijeme.ToLongTimeString(), Color.Red);
                return false;
            }
            else if (text == "/clr" || text =="/clear")
            {
                chatBx.Clear();
                return false;
            }
            else if (text == "/help")
            {
                box.AppendText("/gettime - Ispisuje trenutno vrijeme", Color.Red);
                box.AppendText("/getdate - Ispisuje danasnji datum", Color.Red);
                box.AppendText("/getdatetime - Ispisuje trenutno vrijeme i danasnji datum", Color.Red);
                box.AppendText("/clr ili /clear - Brise chat", Color.Red);
                return false;
            }
            else if(text=="/grobbar")
            {
                MessageBox.Show("Grobar vam je pokrao sve pare iz novcanika.\n" +
                    "Ekonomija Litve, Latvije i ostalih malih zemalja su pale.\n" +
                    "Grobar vam je skuhao vino puno tuge, jadi i cemera.\n" +
                    "Grobar ide vuf vuf..........\n\n\n"+
                    "\"FACE ME... FIGHT ME... GIVE ME A HUG\"", "You activated my Alucard", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                box.AppendText("", Color.Gold);
                box.AppendText("", Color.Gold);
                box.AppendText("", Color.Gold);
                box.AppendText("", Color.Gold);
                return false;
            }
            else if (text == "/sendglobalinfo")
            {
                box.AppendText("Odred izviđača \"Iovallios\" Valpovo", Color.RoyalBlue);
                box.AppendText("Odredski mail: iovallios.valpovo@gmail.com", Color.RoyalBlue);
                box.AppendText("Akcija: JOTA/JOTI 2016", Color.RoyalBlue);
                box.AppendText("Odgovorna osoba: Marko Meisel", Color.RoyalBlue);
                return false;
            }
            else return true;
           
        }

        public adminForm()
        {
            InitializeComponent();

            replyBx.Enabled = false;
            sendBtn.Enabled = false;
            //U ipServertxtBx textbox se upisuje trenutna lokalna IP adresa
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress addr in localIP)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork) ipServertxtBx.Text = addr.ToString();
            }

            porttxtBx.Text = "80";
            box = new RTBExtend(this.chatBx);

            CheckForIllegalCrossThreadCalls = false;
            ClientSockets = new List<Sckt>();
        }



    }
}

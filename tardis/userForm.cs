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
    public partial class userForm : Form
    {

        #region varijable
        RTBExtend box;
        private Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        byte[] receivedBuffer = new byte[1024];
        #endregion

        string user;

        private void button1_Click(object sender, EventArgs e)
        {
            if (replyBx.Text != "" && clientSocket.Connected)
            {
                string textToSend = user + "(" + DateTime.Now.ToLongTimeString() + "): " + replyBx.Text;
                byte[] buffer = Encoding.ASCII.GetBytes(textToSend);
                clientSocket.Send(buffer);
                box.AppendText(textToSend,Color.Black);
                replyBx.Text = "";
            }
        }

        private void ReceiveData(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            int recieved = socket.EndReceive(AR);
            byte[] dataBuffer = new byte[recieved];
            Array.Copy(receivedBuffer, dataBuffer, recieved);
            box.AppendText(Encoding.ASCII.GetString(dataBuffer), Color.Black);
            clientSocket.BeginReceive(receivedBuffer, 0, receivedBuffer.Length, SocketFlags.None, new AsyncCallback(ReceiveData), clientSocket);
        }

        private void sendLoop()
        {
            while(true)
            {
                byte[] receivedBuffer = new byte[1024];
                int rev = clientSocket.Receive(receivedBuffer);
                if (rev != 0)
                {
                    byte[] data = new byte[rev];
                    Array.Copy(receivedBuffer, data, rev);
                    box.AppendText(Encoding.ASCII.GetString(data), Color.Black);
                }
                else clientSocket.Close();
            }
        }

        private void loopConnect()
        {
            int attempts = 0;
            while(!clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch(Exception)
                {

                }
            }
        }

       private void connBtn_Click(object sender, EventArgs e)
        {
            loopConnect();
            clientSocket.BeginReceive(receivedBuffer, 0, receivedBuffer.Length, SocketFlags.None, new AsyncCallback(ReceiveData), clientSocket);
            byte[] buffer = Encoding.ASCII.GetBytes(user);
            clientSocket.Send(buffer);
        }
        public userForm(string username)
        {
            InitializeComponent();
            user = username;
            box = new RTBExtend(chatBx);

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress addr in localIP)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork) ipServertxtBx.Text = addr.ToString();
            }

        }

    }
}

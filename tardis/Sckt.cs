using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace tardis
{
    public class Sckt
    {
        public Socket _Socket { get; set; }
        public string _Name { get; set; }
        public Sckt(Socket s)
        {
            _Socket = s;
        }
    }

}

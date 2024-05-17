using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp;

namespace Exam
{
    class Client
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.Pamagiti();
            ClientApp.Client client = new ClientApp.Client();
            client.Open();

        }
    }
}

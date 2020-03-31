using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija
{
    class Counter
    {
        public int numCounter { get; set; }
        List<Client> clients;

        public Counter(int numCounter)
        {
            this.numCounter = numCounter;
            clients = new List<Client>();
        }

        public void addClient(Client client)
        {
            clients.Add(client);
        }

    }
}

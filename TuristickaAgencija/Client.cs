using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija
{
    class Client
    {
        public String fName { get; set; }
        public String lName { get; set; }
        public Int16 age { get; set; }
        public String destination { get; set; }

        public Client(String fName, String lName, Int16 age, String destination)
        {
            this.fName = fName;
            this.lName = lName;
            this.age = age;
            this.destination = destination;
        }


    }
}

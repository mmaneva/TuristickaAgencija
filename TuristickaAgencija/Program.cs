using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija
{

    class Program
    {
        static void Main(string[] args)
        {
            String fName;
            String lName;
            Int16 age;
            String destination;
            int numBoxOffice;
            Counter[] counters = new Counter[5];

           
            Console.WriteLine("Ime: ");
            fName = Console.ReadLine();
            Console.WriteLine("Prezime: ");
            lName = Console.ReadLine();
            Console.WriteLine("Godini: ");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Destinacija: ");
            destination = Console.ReadLine();
            Console.WriteLine("Broj na salter: ");
            numBoxOffice = Convert.ToInt32(Console.ReadLine());

            Client client = new Client(fName, lName, age, destination);

            if(counters[numBoxOffice] == null)
            {
                counters[numBoxOffice] = new Counter(numBoxOffice);
            }
            else
            {
                counters[numBoxOffice].addClient(client);
            }
            


        }
    }
}

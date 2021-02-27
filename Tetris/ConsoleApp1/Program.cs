using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Human[] humans = new Human[2];
            humans[0] = new Employee(12, 100000);
            humans[1] = new Employee(22, 100000000);
            
            foreach(Human h in humans){
                h.Write();
            }

            Console.ReadLine();
        }
    }
}

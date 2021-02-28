using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    class random
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
           
            for(int i = 0; i<20; i++)
            {
                int value = rand.Next(0, 5);
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}

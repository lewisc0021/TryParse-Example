using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse_Example_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many sides do these die have?");
            int sides;
            while (!int.TryParse(Console.ReadLine(), out sides))
            {
                Console.WriteLine("Please input a correct value.");
            }

        }
    }
}

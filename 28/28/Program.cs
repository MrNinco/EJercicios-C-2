using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;
            Console.WriteLine("Numeros naturales del 0 al 100 ");
            for (cont = 0; cont <= 100; cont++)
            {
                Console.WriteLine("  " + cont);
                Console.WriteLine("-");
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}

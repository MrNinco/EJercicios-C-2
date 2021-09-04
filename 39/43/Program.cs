using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;
            Console.WriteLine("Numeros del 0 al 10 ");
            for (cont = 0; cont <= 10; cont++)
            {
                Console.WriteLine("  " + cont);
                Console.WriteLine("-");
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}

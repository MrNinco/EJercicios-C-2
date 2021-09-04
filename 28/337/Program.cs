using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _337
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Indique el numero");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}|", i);
                }
            }
            Console.Write("\n\n");
            Console.WriteLine("Estos son los multiplos del 3 del numero ingresado");
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write("{0}|", i);
                }
            }
            Console.ReadKey();
        }
    }
}

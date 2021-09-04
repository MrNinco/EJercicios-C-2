using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un numero ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<=n; i++)
            {
                if (i%10==2)
                {
                    Console.Write("{0}|", i);
                }
            }
            Console.ReadKey();
        }
    }
}

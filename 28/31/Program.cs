using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    class Program
    {
        static void Main(string[] args)
        {
            string edad;
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Digite su edad: ");
                edad = Console.ReadLine();
            }
            Console.ReadKey();
        }

    }
}

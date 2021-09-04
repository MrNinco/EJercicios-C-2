using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    class Program
    {
        static void Main(string[] args)
        {
            string edad;
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("escriba su edad: ");
                edad = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}

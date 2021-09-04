using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    class Program
    {
        static void Main(string[] args)
        {
            string genero;
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine("escriba su genero: ");
                genero = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}

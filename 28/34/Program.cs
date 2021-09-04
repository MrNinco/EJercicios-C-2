using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class Program
    {
        static void Main(string[] args)
        {
            int estatura;
            Console.WriteLine("Escriba su estatura:");
            estatura = int.Parse(Console.ReadLine());
            if (estatura <= 140)
            {
                Console.WriteLine("Estudiantes muy bajos ");
            }
            else
            {
                Console.WriteLine("Estudiantes muy altos");
            }
            Console.ReadKey();
        }
    }
}

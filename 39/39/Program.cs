using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class Program
    {
        static void Main(string[] args)
        {
            int Base, exponente, count=0;
            double resultado=1;
            Console.WriteLine("Digite el valor de la base");
            Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor del exponente");
            exponente = int.Parse(Console.ReadLine());
            while (count < exponente)
            {
                resultado = resultado * Base;
                count++;
            }
            Console.WriteLine("La base: " + Base + " Elevada al exponente: " + exponente + " Es: " + resultado);
            Console.ReadKey();
        }
    }
}

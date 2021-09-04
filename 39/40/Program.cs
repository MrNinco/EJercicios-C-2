using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=3, numero2, count = 0;
            double resultado = 1;
            Console.WriteLine("Digite el numero el cual sera sumado por 3: ");
            numero2 = int.Parse(Console.ReadLine());
            while (count < numero)
            {
                resultado = numero + numero2;
                count++;
            }
            Console.WriteLine("Numero 1: " + numero);
            Console.WriteLine("Numero digitado: " + numero2);
            Console.WriteLine("Resultado: " + resultado);
            Console.ReadKey();
        }
    }
}

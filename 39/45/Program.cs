using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, num_factorial, resultado, count = 0;
            Console.WriteLine("Escriba el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el tercer numero: ");
            numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el numero factorial: ");
            num_factorial = int.Parse(Console.ReadLine());
            while (count <= numero1)
            {
                resultado = num_factorial * numero1 * numero2 * numero2 * numero3;
                Console.WriteLine("Su resultado es: "+resultado);
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, numero2, numero3, count=0;
            double mayor = 6;
            Console.WriteLine("Digite 3 numeros del 1 al 6");
            Console.WriteLine("Digite el primer numero: " );
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero: " );
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el tercer numero: " );
            numero3 = int.Parse(Console.ReadLine());
            while (count < mayor)
            {
                Console.WriteLine("su numero es mayor " + mayor);
                Console.ReadKey();
            }
            while (count > mayor)
            {
                Console.WriteLine("Su numero es menor" + mayor);
            }
            Console.ReadKey();
        }
    }
}

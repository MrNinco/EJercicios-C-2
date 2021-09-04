using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantiPro, valorpro, total;
            int iva = 16;
            Console.WriteLine("Escriba la cantidad de productos: ");
            cantiPro = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el valor del producto: ");
            valorpro = int.Parse(Console.ReadLine());
            total = cantiPro * valorpro;
            Console.WriteLine("Su total es: " + total);
            Console.ReadKey();
        }
    }
}

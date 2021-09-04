using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, cubo = 3, quinta = 5, cuarta = 4, count=0;
            double resultado_cub = 1, resultado_cuar=1, resultado_quin=1;
            Console.WriteLine("Digite un numero para sacarle cuarta, quinta, cubo");
            numero1 = int.Parse(Console.ReadLine());
            while (count< resultado_cub)
            {
                resultado_cub = numero1 * cubo;
                resultado_cuar = numero1 * quinta;
                resultado_quin = numero1 * cuarta;
                Console.WriteLine("Su resultado elebado al cubo es: "+ resultado_cub);
                Console.ReadKey();
                Console.WriteLine("Su resultado elebado al cuarta es: "+ resultado_cuar);
                Console.ReadKey();
                Console.WriteLine("Su resultado elebado al quinta es: "+ resultado_quin);
            }
            Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tabla = { 11, 22, 33, 44 };

            for (int i = 0; i < 4; i++)
                Console.WriteLine(tabla[i]);

            foreach (int numero in tabla)
                Console.WriteLine(numero);


            if((3.0 / 7) is int)
            {
                Console.WriteLine("Es de tipo entero");
            }
            else
            {
                Console.WriteLine("No es de tipo entero");
            }
            Console.ReadKey();
        }
    }
}

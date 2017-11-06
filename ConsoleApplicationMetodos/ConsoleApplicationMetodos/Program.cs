using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationMetodos
{
    class Program
    {
        static public int sumar(int n1, int n2) {


            return n1 + n2;
        }
        static void Main(string[] args)
        {
            int num1, num2,resultado;

            Console.WriteLine("Introduce numero 1: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce numero 2: ");
            num2 = Int32.Parse(Console.ReadLine());

            //llamada tradicional
            resultado = sumar(num1, num2);
            Console.WriteLine("La suma es: " + resultado);
            Console.ReadKey();


        }
    }
}

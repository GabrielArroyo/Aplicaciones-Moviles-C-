using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pequeñin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer cadena y numero no insert
            //añada en la posicion del numero "hola"
            //cad ="pepito" y nº2 pepholaito
            //prog Calcular longitud de una cadena de forma recursiva
            //prog interprete de expresiones matematicas
            //"238+12" --> cadena
            string saludo = "Hola";
            string palabra = null;
            string nueva = null;
            int num = 0;
            int j = 0;
            Console.WriteLine("Dime la palabra");
            palabra = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Dime el numero");
            num = Convert.ToInt32(Console.ReadLine());


            // nueva = palabra.Insert(num, saludo);
             
                Console.WriteLine(nueva);


            Console.ReadKey();
        }
        
   }
}

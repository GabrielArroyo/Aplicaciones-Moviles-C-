using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTelevision
{

    class Program
    {
        static int menu(int num)
        {
            num = 0;
            Console.WriteLine("Menu: " + "\n");
            Console.WriteLine("1º Asignar un programa nuevo." + "\n");
            Console.WriteLine("2º Eliminar un programa." + "\n");
            Console.WriteLine("3º Modificar los minutos de un programa." + "\n");
            Console.WriteLine("4º Mostrar programación semanal." + "\n");
            Console.WriteLine("5º Mostrar programación diaria." + "\n");
            Console.WriteLine("6º Mostrar contenidos por día." + "\n");
            Console.WriteLine("9º Salir." + "\n");
            num = Convert.ToInt32(Console.ReadLine());
            return num;

        }
        static void Main(string[] args)
        {
        }
    }
}

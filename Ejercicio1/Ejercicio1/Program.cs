using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program

    { 

        public static int menu()
        {
            int num = 0;
            Console.WriteLine("Menu: " + "\n");
            Console.WriteLine("1º devuelve el número tras truncar la parte decimal a 0 decimales." + "\n");
            Console.WriteLine("2º El método almacena sobre el segundo parámetro el número tras truncarla parte decimal a 0 decimales." + "\n");
            Console.WriteLine("3º El método almacena sobre el primer parámetro el número tras truncar la parte decimal a 0 decimales." + "\n");
            Console.WriteLine("4º Devuelve el número tras truncar la parte decimal a los decimales indicado por el segundo parámetro." + "\n");
            Console.WriteLine("5º El método almacena sobre el tercer parámetro el número tras truncar la parte decimal a los decimales indicado por el segundo parámetro." + "\n");
            Console.WriteLine("6º Almacena sobre el primer parámetro el número tras truncar la parte decimal a los decimales indicado por el segundo parámetro." + "\n");
            Console.WriteLine("9º Salir." + "\n");
            num = Convert.ToInt32(Console.ReadLine());
            return num;


        }

        public static double metodo1(ref double a)
        {
       return  a = Math.Truncate(a);
        }

        public static void metodo2(double b, ref int num)
        {


            b = Math.Truncate(b);
            num += Convert.ToInt32(b);


        }
        public static void metodo3(ref double a)
        {
            a += Math.Truncate(a);
        }

        public static double metodo4(double b, int a)
        { 
            return Math.Round(b, a);
        }

        public static void metodo5(double b, int a,ref double almacen)
        {
            almacen += Math.Round(b,a);

        }

        public static void metodo6(ref double b, int a)
        {
           b += Math.Round(b,a);

        }




        static void Main(string[] args)
        {
            int numdec = 2;
            int opcion;
            int num = 0;
            double valor = 764.783;
            double almacen = 0;

            do
            {
                opcion = menu();
                switch (opcion)
                {
                    case 1:
                        metodo1(ref valor);
                        Console.WriteLine(valor + "\n");
                        break;
                    case 2:
                        metodo2(valor, ref num);
                        Console.WriteLine(num + "\n");
                        break;
                    case 3:
                        metodo3(ref valor);
                        Console.WriteLine(valor + "\n");
                        break;
                    case 4:
                        Console.WriteLine(metodo4(valor, numdec) + "\n");
                        break;
                    case 5:
                        metodo5(valor, numdec, ref almacen);
                        Console.WriteLine(almacen + "\n");
                        break;
                    case 6:
                        metodo6(ref valor,numdec);
                        Console.WriteLine(valor + "\n");
                         break;

               
                }

            } while (opcion != 9);

        }
    }
}

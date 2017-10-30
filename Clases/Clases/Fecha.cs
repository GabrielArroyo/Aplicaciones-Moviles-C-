using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Fecha
    {
        // determina si la fecha se corresponde año bisiesto
        // aumenta el mes +1
        // Crear 3 fechas y leer los valores de las 3 fechas por pantalla, Escriba mayor de todas,
        int dia, mes, anio;
        //Constructores

        public Fecha()
        {
            dia = 1;
            mes = 1;
            anio = 1970;
        }
        public Fecha(int d, int m, int a)
        {
            dia = d;
            mes = m;
            anio = a;
        }

        public bool EsBisiesto(int a)
        {
            if (a % 4 == 0)
                return true;
            else
                return false;

        }


    }
}

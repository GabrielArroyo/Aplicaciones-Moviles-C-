using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTelevision
{
    class ProgramaTelevision
    {
        private string [] Dia = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes","Sabado","Domingo" };
        private string [] Horario = { "Primera Hora", "Matinal", "Mediodia", "Tarde", "Noche" };
        private string [] Programa;
        private string [] DuracionProg;

        public ProgramaTelevision(){
            Programa[1] = "Informativo";
            DuracionProg[1] = "50";       
            
       }    
        
    }
}

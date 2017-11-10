using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTelevision
{
    class ProgramaTelevision
    {
        private string Dia;
        private string [] Horario = { "Primera Hora", "Matinal", "Mediodia", "Tarde", "Noche" };
        private string Programa;
        private string DuracionProg;

        public ProgramaTelevision(){
            Dia = "lunes";
            Programa = "Informativo";
            DuracionProg = "50";       
            
       }    
        
    }
}

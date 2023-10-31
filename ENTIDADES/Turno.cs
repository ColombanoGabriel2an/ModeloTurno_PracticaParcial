using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public enum Estados
    {
        Pendiente = 0,
        Cancelado = 1,
        Terminado = 2
        
    }
    public class Turno
    {
        public int TurnoId {  get; set; }
        public Nutricionista Nutricionista { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime Fecha { get; set; }
        public int Hora { get; set; }
        public Estados Estado { get; set; }

    }


}

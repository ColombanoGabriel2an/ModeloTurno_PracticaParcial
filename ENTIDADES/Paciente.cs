using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string NombreCompleto { get; set; }
        public int Dni { get; set; }
        public string Telefono { get; set; }
        public Cobertura Cobertura { get; set; }
        public DateTime FechaNac { get; set; }
        public string Email { get; set; }

        

    }
}

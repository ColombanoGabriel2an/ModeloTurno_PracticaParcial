using ENTIDADES;
using MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    internal class ControladoraTurnos
    {

        private readonly Context _context;

        public ControladoraTurnos()
        {
            _context = new Context();
        }

        public bool agregarTurno(Turno turno)
        {
            _context.Turnos.Add(turno);
            var insert = _context.SaveChanges();
            if (insert > 0) return true;
            return false;
        }

        public bool eliminarTurno(Turno turno)
        {
            _context.Turnos.Remove(turno);
            var delete = _context.SaveChanges();
            if (delete > 0) return true;
            return false;
        }

        public bool modificarGrupo(Turno turno)
        {
            _context.Turnos.Update(turno);
            var update = _context.SaveChanges();
            if (update > 0) return true;
            return false;
        }

        public List<Turno> listarTurnos()
        {
            return _context.Turnos.ToList();
        }

        public Turno listarGrupo(int idTurno)
        {
            return _context.Turnos.First(x => x.TurnoId == idTurno);
        }







    }
}

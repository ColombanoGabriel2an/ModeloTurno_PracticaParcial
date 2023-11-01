using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MODELO.Context;

namespace MODELO
{
    public class Context : DbContext
    {
        public DbSet<ENTIDADES.Paciente> Pacientes { get; set; }
        public DbSet<ENTIDADES.Turno> Turnos { get; set; }
        public DbSet<ENTIDADES.Nutricionista> Nutricionistas { get; set; }
        public DbSet<ENTIDADES.Cobertura> Coberturas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"data source=(localdb)\MSSQLLocalDB;Initial Catalog=SEGURIDAD;Integrated Security=true");

    }
}

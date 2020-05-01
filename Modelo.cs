using System.Collections.Generic;
using EFGetStarted.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted
{
    public class ContextoHospital : DbContext
    {
        public DbSet<Caso> Casos { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Prueba> Pruebas { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=hospital.db");
    }
}
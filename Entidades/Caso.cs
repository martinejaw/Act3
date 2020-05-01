using System.ComponentModel.DataAnnotations.Schema;

namespace EFGetStarted.Entidades
{    
    public class Caso
    {
        public int CasoId { get; set; }

        public int medicomatricula { get; set; }
        public Medico medico { get; set; }

        public int pacientedni { get; set; }
        public Paciente paciente { get; set; }
        public string estado { get; set; }
    }
}
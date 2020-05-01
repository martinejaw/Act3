
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFGetStarted.Entidades
{    
    public class Paciente
    {
        [Key]
        public int dni { get; set; }
        
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellido { get; set; }
        public DateTime fechaNac { get; set; }


        public List<Consulta> consultas { get; } = new List<Consulta>();
    }
}
        
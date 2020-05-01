using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFGetStarted.Entidades
{    
    public class Medico
    {

        public Medico(){
            this.casos = new HashSet<Caso>();
        }

        [Key]
        public int matricula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public List<Consulta> consultas { get; set; } = new List<Consulta>();
        public virtual ICollection<Caso> casos { get; set; }
    }
}
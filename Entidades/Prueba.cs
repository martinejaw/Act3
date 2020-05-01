using System;

namespace EFGetStarted.Entidades
{    
    public class Prueba
    {
        public int PruebaId { get; set; }
        public bool resultado { get; set; }
        public DateTime fecha { get; set; }
        public DateTime fechaResultado { get; set; }
        public Caso caso { get; set; }
    }
}
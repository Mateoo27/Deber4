using System.Collections.Generic;

namespace VintageStuff.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Camiseta> Camisetas { get; set; } = new List<Camiseta>();
        public List<Boxer> Boxeres { get; set; } = new List<Boxer>();
        public List<Pantalon> Pantalones { get; set; } = new List<Pantalon>();
        public List<Polin> Polines { get; set; } = new List<Polin>();
        public List<Top> Topes { get; set; } = new List<Top>();
    }
}
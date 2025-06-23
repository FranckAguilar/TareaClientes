using System.ComponentModel.DataAnnotations;

namespace demoasp1.Models
{
    public class Familia
    {
        [Key]
        public int IdFamilia { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
    }
}
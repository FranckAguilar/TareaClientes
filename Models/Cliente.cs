using System.ComponentModel.DataAnnotations;

namespace demoasp1.Models
{
    public class Cliente
    {
        [Key]
        public int IDCliente { get; set; }

        public string? Nombres { get; set; }

        public string? Apellidos { get; set; }

        public string? DNI { get; set; }
    }
}
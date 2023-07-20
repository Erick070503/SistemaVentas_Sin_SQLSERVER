using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Rol
    {
        public Rol() {
            Usuarios = new HashSet<Usuario>();
        }
        [Key] public int IdRol { get; set; }
        public string? Nombre { get; set; } = null!;
        public DateTime? FechaRegistro { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
}

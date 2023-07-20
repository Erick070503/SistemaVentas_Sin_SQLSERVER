using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Usuario
    {
        [Key] public int Idusuario { get; set; }
        public string Usuario1 { get; set; } = null!;
        public int Contraseña { get; set; }
        public int IdRol {get; set; }
        public string Estado { get; set; } = null!;

        public Rol IdRolNavigation { get; set; } = null!;
    }
}

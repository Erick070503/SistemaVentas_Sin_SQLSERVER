using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Cliente
    {
        public Cliente()
        {
            Venta = new HashSet<Venta>();
        }
        [Key] public int Idcliente { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public int cedula { get; set; }
        public string Sexo { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public int Telefono { get; set; }
        public string Estado { get; set; } = null!;

        public ICollection<Venta> Venta { get; set; }
    }
}

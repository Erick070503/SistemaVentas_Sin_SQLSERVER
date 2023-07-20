using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Detalleventa
    {
        public Detalleventa() {
            Ventas = new HashSet<Venta>();
        }
        [Key] public int Idnumdocumento { get; set; }
        public string Serie { get; set; } = null!;
        public int Idproducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public Producto IdproductoNavigation { get; set; } = null!;
        public ICollection<Venta> Ventas { get; set; }
    }
}

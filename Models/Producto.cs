using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Producto
    {
        public Producto()
        {
            Detalleventa = new HashSet<Detalleventa>();
        }
        [Key] public int Idproducto { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int Idcategoria { get; set; }
        public string Estado { get; set; } = null!;

        public Categoria IdcategoriaNavigation { get; set; } = null!;
        public ICollection<Detalleventa> Detalleventa { get; set; }
    }
}

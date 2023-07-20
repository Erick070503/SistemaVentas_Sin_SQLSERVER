using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Productos = new HashSet<Producto>();
        }
        [Key] public int Idcategoria { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Estado { get; set; } = null!;

        public ICollection<Producto> Productos { get; set; }
    }
}

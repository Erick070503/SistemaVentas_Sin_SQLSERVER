using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Venta
    {
        [Key] public int Idventa { get; set; }  
        public int Idnumdocumento { get; set; }
        public string Serie { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int Idcliente { get; set; }
        public string cedula { get; set; } = null!;
        public decimal Total { get; set; }
        public string Estado { get; set; } = null!;

        public Cliente IdclienteNavigation { get; set; } = null!;
        public Detalleventa IdnumdocumentoNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class WebApplication4Context : DbContext
    {
        public WebApplication4Context (DbContextOptions<WebApplication4Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication4.Models.Categoria> Categoria { get; set; } = default!;

        public DbSet<WebApplication4.Models.Cliente>? Cliente { get; set; }

        public DbSet<WebApplication4.Models.Detalleventa>? Detalleventa { get; set; }

        public DbSet<WebApplication4.Models.Producto>? Producto { get; set; }

        public DbSet<WebApplication4.Models.Rol>? Rol { get; set; }

        public DbSet<WebApplication4.Models.Usuario>? Usuario { get; set; }

        public DbSet<WebApplication4.Models.Venta>? Venta { get; set; }
    }
}

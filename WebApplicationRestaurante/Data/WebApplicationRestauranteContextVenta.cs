using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationRestaurante.Models.Venta;

namespace WebApplicationRestaurante.Data
{
    public class WebApplicationRestauranteContextVenta : DbContext
    {
        public WebApplicationRestauranteContextVenta (DbContextOptions<WebApplicationRestauranteContextVenta> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationRestaurante.Models.Venta.Ventas> Venta { get; set; } = default!;
    }
}

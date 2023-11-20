using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationRestaurante.Models.Detalle;

namespace WebApplicationRestaurante.Data
{
    public class WebApplicationRestauranteContextFactura : DbContext
    {
        public WebApplicationRestauranteContextFactura (DbContextOptions<WebApplicationRestauranteContextFactura> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationRestaurante.Models.Detalle.Factura> Factura { get; set; } = default!;
    }
}

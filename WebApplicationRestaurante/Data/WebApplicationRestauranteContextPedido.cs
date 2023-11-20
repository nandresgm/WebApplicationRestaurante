using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationRestaurante.Models.Pedidos;

namespace WebApplicationRestaurante.Data
{
    public class WebApplicationRestauranteContextPedido : DbContext
    {
        public WebApplicationRestauranteContextPedido (DbContextOptions<WebApplicationRestauranteContextPedido> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationRestaurante.Models.Pedidos.Pedido> Pedido { get; set; } = default!;
    }
}

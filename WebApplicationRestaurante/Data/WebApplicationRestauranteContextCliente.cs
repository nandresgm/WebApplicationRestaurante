using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationRestaurante.Models.Clientes;

namespace WebApplicationRestaurante.Data
{
    public class WebApplicationRestauranteContextCliente : DbContext
    {
        public WebApplicationRestauranteContextCliente (DbContextOptions<WebApplicationRestauranteContextCliente> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationRestaurante.Models.Clientes.Cliente> Cliente { get; set; } = default!;
    }
}

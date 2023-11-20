using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationRestaurante.Models.Clientes;
using WebApplicationRestaurante.Models.Ingredientes;

namespace WebApplicationRestaurante.Data
{
    public class WebApplicationRestauranteContextIngredientes : DbContext
    {
        public WebApplicationRestauranteContextIngredientes (DbContextOptions<WebApplicationRestauranteContextIngredientes> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationRestaurante.Models.Clientes.Cliente> Cliente { get; set; } = default!;

        public DbSet<WebApplicationRestaurante.Models.Ingredientes.Ingrediente>? Ingrediente { get; set; }
    }
}

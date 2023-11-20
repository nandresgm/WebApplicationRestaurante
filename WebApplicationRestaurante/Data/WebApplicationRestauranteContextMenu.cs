using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationRestaurante.Models.Menus;

namespace WebApplicationRestaurante.Data
{
    public class WebApplicationRestauranteContextMenu : DbContext
    {
        public WebApplicationRestauranteContextMenu (DbContextOptions<WebApplicationRestauranteContextMenu> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationRestaurante.Models.Menus.Menus> Menu { get; set; } = default!;
    }
}

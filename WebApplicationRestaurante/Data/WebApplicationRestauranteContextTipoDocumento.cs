using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationRestaurante.Models.TipoDocumento;

namespace WebApplicationRestaurante.Data
{
    public class WebApplicationRestauranteContextTipoDocumento : DbContext
    {
        public WebApplicationRestauranteContextTipoDocumento (DbContextOptions<WebApplicationRestauranteContextTipoDocumento> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationRestaurante.Models.TipoDocumento.TipoDocumentos> TipoDocumento { get; set; } = default!;
    }
}

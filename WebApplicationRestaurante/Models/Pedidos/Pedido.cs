using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace WebApplicationRestaurante.Models.Pedidos
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Cliente { get; set; }

        public DateTime Fecha { get; set; }
    }
}

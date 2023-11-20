namespace WebApplicationRestaurante.Models.Menus
{
    public class Menus
    {
        public int Id { get; set; }
        public string NombreMenu { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public int Ingredientes { get; set; }
        public Boolean  Disponibilidad { get; set; }

    }
}

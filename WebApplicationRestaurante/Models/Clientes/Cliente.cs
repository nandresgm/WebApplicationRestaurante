namespace WebApplicationRestaurante.Models.Clientes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string NumeroDocumento { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public int TipoDocumento { get; set; } = 0;
        public string CorreoElectronico { get; set; } = string.Empty;

    }
}

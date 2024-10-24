namespace SchoolTransportManagement.Domain
{
    public class Estudiante
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public required string Direccion { get; set; }
        public int RutaId { get; set; }
        public required Ruta Ruta { get; set; } // Relación con Ruta
    }

}

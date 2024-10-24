using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTransportManagement.Domain
{
    public class Ruta
    {
        public int Id { get; set; }
        public required string NombreRuta { get; set; }
        public required string Descripcion { get; set; }
        public required List<Estudiante> Estudiantes { get; set; } // Relación con Estudiantes
    }

}

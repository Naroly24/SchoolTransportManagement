using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTransportManagement.Domain
{
    public class Conductor
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string LicenciaConducir { get; set; }
        public required List<Vehiculo> Vehiculos { get; set; } // Relación con Vehículos
    }

}

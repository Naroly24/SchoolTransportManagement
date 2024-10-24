using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTransportManagement.Domain
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public required string Marca { get; set; }
        public required string Modelo { get; set; }
        public required string Placa { get; set; }
        public int ConductorId { get; set; }
        public required Conductor Conductor { get; set; } // Relación con Conductor
    }

}

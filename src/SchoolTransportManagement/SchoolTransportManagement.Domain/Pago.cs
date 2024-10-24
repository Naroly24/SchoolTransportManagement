using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTransportManagement.Domain
{
    public class Pago
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public required Estudiante Estudiante { get; set; } // Relación con Estudiante
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public bool Pagado { get; set; }
    }

}

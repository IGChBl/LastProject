using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class FacturaReporte
    {
        public string NumeroFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public string NombreCliente { get; set; }
        public string ServicioNombre { get; set; }
        public decimal ServicioPrecio { get; set; }
        public decimal TotalFactura { get; set; }
    }
}

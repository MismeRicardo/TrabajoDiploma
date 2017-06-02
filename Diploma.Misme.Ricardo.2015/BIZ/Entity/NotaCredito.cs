using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.Entity
{
    public class NotaCredito
    {
        public DateTime Fecha { get; set; }
        public Factura unaFactura { get; set; }
        
    }
}

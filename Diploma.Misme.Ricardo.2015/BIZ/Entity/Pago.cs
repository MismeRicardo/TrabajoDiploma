using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Framework.Misme.Persistencia;

namespace BIZ.Entity
{
    public class Pago //: IConexionEjecutarResultado
    {
        
        public DateTime FechaPago { get; set;}
        public double MontoAPagar { get; set;}
        public Factura unaFactura { get; set; }
    }
}

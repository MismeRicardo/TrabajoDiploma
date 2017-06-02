using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Misme.Persistencia;
namespace BIZ.Entity
{
    public class Factura : IConexionEjecutarResultado
    {
        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }       
        public double Total { get; set; }
        public string FormaPago { get; set; }
        public string TipoFactura { get; set; }
        public Cuenta unaCuenta { get; set; }

       

    }
}

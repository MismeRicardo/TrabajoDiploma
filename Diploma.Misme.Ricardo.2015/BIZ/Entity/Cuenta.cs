using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Misme.Persistencia;

namespace BIZ.Entity
{
    public class Cuenta : IConexionEjecutarResultado
    {
        public int  NroCuenta {get; set;}
        public double Total { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public Cliente unCliente { get; set; }
        

    }
}

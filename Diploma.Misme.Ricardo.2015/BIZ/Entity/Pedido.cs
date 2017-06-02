using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Framework.Misme.Persistencia;

namespace BIZ.Entity
{
    public class Pedido// : IConexionEjecutarResultado
    {
        public int NroPedido { get; set; }
        public List<Plato> Platos { get; set; }
        public List<Bebida> Bebidas { get; set; }

    }
}

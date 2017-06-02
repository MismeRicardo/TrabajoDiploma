using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Framework.Misme.Persistencia;

namespace BIZ.Entity
{
    public class Plato// : IConexionEjecutarResultado
    {
        public Guid CodPlato { get; set; }
        public string Estado { get; set; }        
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public List<Insumo> Insumos { get; set; }




    }
}

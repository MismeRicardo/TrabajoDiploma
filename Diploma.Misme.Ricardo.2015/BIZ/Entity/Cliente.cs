using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Misme.Persistencia;
namespace BIZ.Entity
{
    public class Cliente : IConexionEjecutarResultado
    {
        public int DNI {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Direccion {get; set;}
        public string Mail { get; set; }
        public List<Telefono> Telefonos  {get; set;}
        public List<Mesa> Mesas { get; set;}
        
        

    }
}

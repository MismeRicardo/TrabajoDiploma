using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Framework.Misme.Persistencia;

namespace BIZ.Entity
{
   public class Usuario //: IConexionEjecutarResultado
    {
       public string usu { get; set;}
       public string cont { get; set; }
       public List<FamiliaElement> Permisos { get; set;}







    }
}

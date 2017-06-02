using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Framework.Misme.Persistencia;

namespace BIZ.Entity
{
    public class Patente : FamiliaElement//,IConexionEjecutarResultado
    {
       public override int ChildrenCount
       {
           get { return 0; }
       }

       public override void Agregar(FamiliaElement a)
       {
           throw new Exception("No se puede agregar una patente");
       }

       public override void Quitar(FamiliaElement r)
       {
           throw new Exception("No se puede quitar una patente");
       }
    }
}

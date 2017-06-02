using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Framework.Misme.Persistencia;
namespace BIZ.Entity
{
    public class Familia : FamiliaElement//, IConexionEjecutarResultado
    {


        public List<FamiliaElement> Accesos { get; set; }
        
        
        public override int ChildrenCount
        {
            get{return this.Accesos.Count;}
        }




        public override void Agregar(FamiliaElement a)
        {
            this.Accesos.Add(a);
        }

        public override void Quitar(FamiliaElement r)
        {
            this.Accesos.Remove(r);
        }
    }
}

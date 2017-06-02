using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.Entity
{
    public abstract class FamiliaElement
    {
        public Guid idFamiliaElement { get; set;}
        public string Nombre { get; set; }

        public abstract int ChildrenCount { get; }


        public abstract void Agregar(FamiliaElement a);
        public abstract void Quitar(FamiliaElement r);

        public FamiliaElement() {
            this.idFamiliaElement = new Guid();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Framework.Misme.Persistencia;

namespace BIZ.Entity
{
    public class Reserva// : IConexionEjecutarResultado
    {
        public string CodReserva {get; set;}
        public DateTime FechaReserva { get; set; }
        public DateTime HoraReserva { get; set; }
        public int CantPersonas { get; set; }
        public Cliente unCliente { get; set; }

    }
}

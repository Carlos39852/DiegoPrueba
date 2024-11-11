using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class TarjetaCredito
    {
        public int TarjetaID { get; set; }
        public string Num_Tarjeta {  get; set; }
        public string CVC { get; set; }
        public DateTime Fecha_Vencimiento { get; set; } 
        public virtual ICollection<Cliente> Clientes { get; set; }

    }
}

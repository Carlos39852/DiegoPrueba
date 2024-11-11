using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class ComprobantePago
    {
        public int ComprobantePagoID { get; set; }
        public int VentaID { get; set; }    
        public virtual Venta Venta { get; set; }
        public DateTime Fecha_emision { get; set; }


    }
}

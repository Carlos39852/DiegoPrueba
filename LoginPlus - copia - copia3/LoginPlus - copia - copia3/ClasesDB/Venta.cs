using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class Venta
    {
        public int VentasID { get; set; }
        public DateTime Fecha_venta { get; set; }
        public decimal Costo_envio { get; set; }
        public decimal Monto_total { get; set; }
        public int ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int MetodoPagoID { get; set; }
        public virtual ICollection<VentaProducto> VentaProducto { get; set; }

        public Venta()
        {
            VentaProducto = new List<VentaProducto>();

        }
    }
}

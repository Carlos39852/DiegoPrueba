using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class VentaProducto
    {
        public int VentaProductoID { get; set; }
        public int VentasID { get; set; }
        public virtual Venta Venta { get; set; }
        public int ProductoID { get; set; }
        public virtual Productos Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_unitario { get; set; }
    }
}

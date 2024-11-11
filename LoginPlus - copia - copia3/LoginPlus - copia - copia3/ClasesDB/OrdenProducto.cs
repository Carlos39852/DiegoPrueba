using Login.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class OrdenProducto
    {
        public int OrdenProductoID { get; set; }
        public int OrdenPedidoID { get; set; }
        public virtual OrdenPedido OrdenPedido { get; set; }
        public int ProductoID { get; set; }
        public virtual Productos Productos { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }


    }
}

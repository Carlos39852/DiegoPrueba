using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public  class OrdenPedido
    {
        public int OrdenPedidosID { get; set; }
        public DateTime fecha_pedido {  get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public bool Activo { get; set; }
        public int ProductoProveedorID { get; set; }
        public int ProveedorID { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual ProductoProveedor ProductoProveedor { get; set; }
        public decimal monto_total {  get; set; }
    }
}

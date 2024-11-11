using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public  class Precio
    {
        public int PrecioID {  get; set; }
        public int ProductoProveedorID { get; set; }
        public int ProveedorID { get; set; }
        public decimal PrecioUnitario { get; set; }

        public virtual ProductoProveedor ProductoProveedor{ get; set; }
       public virtual Proveedor Proveedor{ get; set; }
    }
}

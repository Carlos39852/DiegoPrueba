using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class ProductoProveedor
    {
       public int  ProductoProveedorID { get; set; }
       public int ProveedorID { get; set; }
       
        public string Nombre_Producto {  get; set; }

        public virtual Proveedor Proveedor { get; set; }
     
       
    }
}

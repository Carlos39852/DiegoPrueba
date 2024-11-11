using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class Productos
    {

        public int ProductoID { get; set; }
       
        
        public int stock_actual {  get; set; }
        public int stock_minimo {  get; set; }
        public DateTime Fecha_caducidad {  get; set; }

        //relacion con categoria
        public int CategoriaID {  get; set; }
        public virtual Categoria Categoria { get; set; }

        // Relación con la tabla intermedia ProductoProveedor
        public int ProductoProveedorID { get; set; }
        public virtual ProductoProveedor ProductoProveedor { get; set; }



    }
}

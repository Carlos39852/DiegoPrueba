using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class Proveedor
    {
        public int ProveedorID { get; set; }
        public string Nombre_proveedor { get; set; }
        public int Telefono {  get; set; }
        public string email { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }

        public Proveedor()
        {
            Productos = new List<Productos>();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class Permiso
    {
        public int PermisoID { get; set; }
        public string Descripcion { get; set; }
        //relacion con roles
        public virtual ICollection<PermisoRol> PermisoRol { get; set; }

    }
}

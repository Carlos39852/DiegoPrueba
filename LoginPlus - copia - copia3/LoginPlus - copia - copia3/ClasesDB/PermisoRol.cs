using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class PermisoRol
    {
        public int PermisoRolID { get; set; }
        //relacion con rol
        public int RolID { get; set; }
        public virtual Rol Rol { get; set; }
        //relacion con permiso
        public int PermisoID { get; set; }
        public virtual Permiso Permiso { get; set; }

    }
}

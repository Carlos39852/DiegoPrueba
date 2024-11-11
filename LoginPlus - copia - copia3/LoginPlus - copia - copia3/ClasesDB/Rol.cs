using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class Rol
    {

        public int RolID { get; set; }
        public string Nombre_rol { get; set; }

        //relacion con permiso
        public virtual ICollection<PermisoRol> PermisoRol { get; set; }
        //relacion con usuarios
        public virtual ICollection<Usuario> Usuarios { get; set; }

    }
}

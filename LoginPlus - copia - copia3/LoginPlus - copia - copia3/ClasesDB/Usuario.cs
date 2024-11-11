using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contraseña { get; set; }
        public DateTime Fecha_registro { get; set; }
        public bool Activo { get; set; }

        //Relacion con la tabla rol
        public int RolID { get; set; }
        public virtual Rol Rol { get; set; }


    }
}

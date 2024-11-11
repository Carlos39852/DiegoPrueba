using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class Direccion
    {
        public int DireccionID { get; set; }    
        public int DepartamentosID{ get; set; }
        public int MunicipioID { get; set; }   
        public string Calle {  get; set; }

        public virtual Departamento Departamento { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual ICollection<Cliente> Clientes {  get; set; }
    }
}

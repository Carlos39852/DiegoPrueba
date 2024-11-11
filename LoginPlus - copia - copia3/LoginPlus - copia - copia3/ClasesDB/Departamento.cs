using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class Departamento
    {
        public int DepartamentosID {  get; set; }
        public string Depar { get; set; }
        public virtual ICollection<Municipio> Municipios { get; set; }


    }
}

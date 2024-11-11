using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class Municipio
    {
        public int MunicipioID { get; set; }
        public string NombreMunicipio { get; set; }
        public int DepartamentosID { get; set; }
        public virtual  Departamento Departamento { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string Nombre_categoria { get; set; }
        public string Descripcion {  get; set; }
        public virtual ICollection<Productos> Productos { get; set; }

        public Categoria()
        {
            Productos = new List<Productos>();
        }

    }
}

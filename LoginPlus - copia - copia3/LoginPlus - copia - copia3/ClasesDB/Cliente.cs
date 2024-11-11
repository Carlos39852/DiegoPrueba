using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nombre_cliente { get; set; }
        public string Email { get; set; }
        public string Contraseña {  get; set; }
        public string Telefono {  get; set; }
        public int DireccionID {  get; set; }
        public virtual Direccion Direccion {  get; set; }
        public int TarjetaID { get; set; }
        public virtual TarjetaCredito TarjetaCredito {  get; set; }
    }
}

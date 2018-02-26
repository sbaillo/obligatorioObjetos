using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_Clases
{
    public class Usuario
    {
        public string id { get; }
        public string nombre { get; set; }
        public string password { get; set; }
        public string rol { get; set; }

        public Usuario(string unId, string unNombre, string unPassword, string unRol)
        {
            this.id = unId;
            this.nombre = unNombre;
            this.password = unPassword;
            this.rol = unRol;
        }

        public bool ValidarRol(string rol)
        {

        }
    }
}

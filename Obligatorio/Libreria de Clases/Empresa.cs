using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_Clases
{
    public class Empresa:Cliente
    {
        public string rut { get;}
        public string razonSocial { get; set; }
        public string nombreContacto { get; set; }

        public Empresa(string unRut, string unaRazonSocial, string unNombre)
        {
            this.rut = unRut;
            this.razonSocial = unaRazonSocial;
            this.nombreContacto = unNombre;
        }
    }
}

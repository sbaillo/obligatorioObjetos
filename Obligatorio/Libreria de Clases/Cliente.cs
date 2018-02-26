using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_Clases
{
    public class Cliente
    {
        public int anioAlta { get; set; }
        public string telefono { get; set; }

        public Cliente (int unAnioAlta, string unTelefono)
        {
            this.anioAlta = unAnioAlta;
            this.telefono = unTelefono;
        }

        public bool ValidarAnio(string anio)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_Clases
{
    public class Particular
    {
        public string numeroDoc { get; }
        public string tipoDoc { get; set; }
        public string paisDoc { get; set; }
        public string nombre { get; }
        public string apellido { get; }
        public double descuento { get; set; }

        public Particular (string unNumeroDoc, string unTipoDoc, string unPaisDoc, string unNombre, string unApellido, double unDescuento)
        {
            this.numeroDoc = unNumeroDoc;
            this.tipoDoc = unTipoDoc;
            this.paisDoc = unPaisDoc;
            this.nombre = unNombre;
            this.apellido = unApellido;
            this.descuento = unDescuento;
        }

        public bool ValidarTipoDoc(string tipo)
        {

        }
    }
}

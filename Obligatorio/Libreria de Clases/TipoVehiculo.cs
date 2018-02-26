using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_Clases
{
    public class TipoVehiculo
    {
        public string marca { get; }
        public string modelo { get; set; }
        public double precioDiario { get; set; }

        public TipoVehiculo (string unaMarca, string unModelo, double unPrecioDiario)
        {
            this.marca = unaMarca;
            this.modelo = unModelo;
            this.precioDiario = unPrecioDiario;
        }
    }
}

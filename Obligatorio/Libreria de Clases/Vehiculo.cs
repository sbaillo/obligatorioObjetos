using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_Clases
{
    public class Vehiculo
    {
        public string matricula { get; }
        public TipoVehiculo tipo { get; }
        public int anio { get; set; }
        public int kilometraje { get; set; }
        public List<string> rutasFotos { get; set; }
        public bool disponible { get; set; }

        public Vehiculo (string unaMatricula, TipoVehiculo unTipo, int unAnio, int unKilometraje, List<string> lasRutasFotos, bool esDisponible)
        {
            this.matricula = unaMatricula;
            this.tipo = unTipo;
            this.anio = unAnio;
            this.kilometraje = unKilometraje;
            this.rutasFotos = lasRutasFotos;
            this.disponible = esDisponible;
        }
    }
}

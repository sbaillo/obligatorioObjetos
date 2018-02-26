using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_Clases
{
    class CAlquileres
    {
        private static CAlquileres instancia;
        public static CAlquileres Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new CAlquileres();
                }

                return instancia;
            }
        }

        private List<Alquiler> alquileres;

        private CAlquileres()
        {
            alquileres = new List<Alquiler>();
        }

        //ALQUILER VEHICULO
        public Enum AlquilerVehiculo(Cliente unCliente, DateTime laFechaIni, DateTime laFechaFin, DateTime laHoraIni, DateTime laHoraFin, Vehiculo unVehiculo, Usuario unVendedor)
        {
           
        }

        //BUSCAR RETRASADOS
        public List<Alquiler> BuscarRetrasados()
        {
            foreach (Alquiler A in alquileres)
            {
                if ()
                {

                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_Clases
{
    class CVehiculos
    {
        private static CVehiculos instancia;
        public static CVehiculos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new CVehiculos();
                }

                return instancia;
            }
        }

        private List<Vehiculo> vehiculos;

        private CVehiculos()
        {
            vehiculos = new List<Vehiculo>();
        }

        //BUSCAR VEHICULO
        public Vehiculo BuscarVehiculo(string unaMatricula)
        {
            Vehiculo retorno = null;

            bool loEncontre = false;
            int pos = 0;
            while (!loEncontre && pos < vehiculos.Count)
            {
                if (vehiculos[pos].matricula == unaMatricula)
                {
                    retorno = vehiculos[pos];
                    loEncontre = true;
                }
                pos++;
            }

            return retorno;
        }

        //AlTA VEHICULO
        public bool AltaUsuario(string unaMatricula, TipoVehiculo unTipo, int unKilometraje, List<string> lasRutasFotos, bool esDisponible)
        {
            bool ok = false;
            if (this.BuscarVehiculo(unaMatricula) == null)
            {

                Vehiculo unVehiculo = new Vehiculo(unaMatricula, unTipo, unKilometraje, unKilometraje, lasRutasFotos, esDisponible );

                vehiculos.Add(unVehiculo);

                ok = true;
            }
            return ok;
        }

        //BUSCAR DISPONIBLES
        public List<Vehiculo> BuscarDisponibles()
        {
            List<Vehiculo> listaAux = new List<Vehiculo>();

            foreach(Vehiculo V in vehiculos)
            {
                if(V.disponible == true)
                {
                    listaAux.Add(V);
                }
            }

            return listaAux;
        }


    }
}

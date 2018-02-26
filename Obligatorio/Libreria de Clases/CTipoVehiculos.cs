using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_Clases
{
    class CTipoVehiculos
    {
        private static CTipoVehiculos instancia;
        public static CTipoVehiculos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new CTipoVehiculos();
                }

                return instancia;
            }
        }

        private List<TipoVehiculo> tiposVehiculo;

        private CTipoVehiculos()
        {
            tiposVehiculo = new List<TipoVehiculo>();
        }

        //ALTA TIPO VEHICULO
        public bool AltaTipoVehiculo(string unaMarca, string unModelo, double unPrecioDiario)
        {
            bool ok = false;
            if (this.BuscarTipoVehiculo(unaMarca, unModelo) == null)
            {

                TipoVehiculo unTipoVehiculo = new TipoVehiculo();

                tiposVehiculo.Add(unTipoVehiculo);

                ok = true;
            }
            return ok;
        }

        //BUSCAR TIPO VEHICULO

        public TipoVehiculo BuscarTipoVehiculo(string marca , string modelo)
        {
            TipoVehiculo retorno = null;

            bool loEncontre = false;
            int pos = 0;
            while (!loEncontre && pos < tiposVehiculo.Count)
            {
                if (tiposVehiculo[pos].marca == marca && tiposVehiculo[pos].modelo == modelo)
                {
                    retorno = tiposVehiculo[pos];
                    loEncontre = true;
                }
                pos++;
            }

            return retorno;
        }


    }
}

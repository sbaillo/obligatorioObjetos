using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_Clases
{
    public class Alquiler
    {
        public Cliente cliente { get; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFin { get; set; }
        public Vehiculo vehiculo { get; }
        public Usuario vendedor { get; }
        public bool cerrado { get; set; }
        public double precioFinal {get; set;}

        public Alquiler (Cliente unCliente, DateTime laFechaInicio, DateTime laFechaFin, DateTime laHoraInicio, DateTime laHoraFin, Vehiculo unVehiculo, Usuario unVendedor, bool esCerrado, double elPrecioFinal)
        {
            this.cliente = unCliente;
            this.fechaInicio = laFechaInicio;
            this.fechaFin = laHoraFin;
            this.horaInicio = laHoraInicio;
            this.horaFin = laHoraFin;
            this.vehiculo = unVehiculo;
            this.vendedor = unVendedor;
            this.cerrado = esCerrado;
            this.precioFinal = elPrecioFinal;
        }

        public bool Atrasado(DateTime fecha)
        {

        }
    }
}

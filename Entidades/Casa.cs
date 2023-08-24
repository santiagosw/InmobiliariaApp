using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Casa
    {
        public string Direccion { get; set; }
        public decimal Precio { get; set; }
        public bool Disponible { get; set; }
        public DateTime FechaConstruccion { get; set; }

        public Casa(string direccion, decimal precio, bool disponible, DateTime fechaConstruccion)
        {
            Direccion = direccion;
            Precio = precio;
            Disponible = disponible;
            FechaConstruccion = fechaConstruccion;
        }

    }
}

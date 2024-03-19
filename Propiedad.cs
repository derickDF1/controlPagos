using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlPagos
{
    class Propiedad
    {
        string numeroCasa;
        int dpiPropietario;
        decimal cuotaMantenimiento;

        public string NumeroCasa { get => numeroCasa; set => numeroCasa = value; }
        public int DpiPropietario { get => dpiPropietario; set => dpiPropietario = value; }
        public decimal CuotaMantenimiento { get => cuotaMantenimiento; set => cuotaMantenimiento = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlPagos
{
    class PropiedadDueño
    {
        int dpi;
        string nombre;
        string apellido;
        string numCasa;
        decimal cuotaMantenimiento;

        public int Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NumCasa { get => numCasa; set => numCasa = value; }
        public decimal CuotaMantenimiento { get => cuotaMantenimiento; set => cuotaMantenimiento = value; }
    }
}

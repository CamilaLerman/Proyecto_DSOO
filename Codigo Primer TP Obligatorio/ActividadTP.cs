using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Entrega_PI.Codigo_Mati
{
    internal class ActividadMati
    {
        public String Nombre { get; private set; }
        public int Cupos { get; private set; }

        public ActividadMati(string nombre, int cupoMaximo)
        {
            Nombre = nombre;
            Cupos = cupoMaximo;
        }

        public void DescontarCupo()
        {
            if (Cupos > 0) Cupos--;
        }

        public bool HayCupo()
        {
            return Cupos > 0;
        }

    }
}

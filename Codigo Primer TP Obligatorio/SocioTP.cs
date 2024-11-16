using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Entrega_PI.Codigo_Mati
{
    internal class SocioMati
    {
        public String Nombre { get; private set; }
        public int Id { get; private set; }

        List<ActividadMati> actividadesInscriptas;


        public SocioMati(String nombre, int id)
        {
            Nombre = nombre;
            Id = id;
            actividadesInscriptas = new List<ActividadMati>();
        }

        public bool InscribirActividad(ActividadMati actividad)
        {
            bool resultado = false;
            if (!actividadesInscriptas.Contains(actividad))
            {
                actividadesInscriptas.Add(actividad);
                resultado = true;
            }
            return resultado;
        }

        public int CantidadActividadesInscriptas()
        {
            return actividadesInscriptas.Count;
        }

    }
}

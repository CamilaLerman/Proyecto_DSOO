using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Entrega_PI.Codigo_Mati
{
    internal class ClubDeportivoTP
    {
        List<SocioMati> socios;
        List<ActividadMati> actividades;

        const int MAX_ACTIVIDADES_POR_SOCIO = 3;
        public ClubDeportivoTP()
        {
            socios = new List<SocioMati>();
            actividades = new List<ActividadMati>();
        }

        public bool AltaSocio(String nombre, int id)
        {
            if (!ExisteSocio(id))
            {
                socios.Add(new SocioMati(nombre, id));
                return true;
            }
            return false;
        }

        public bool AltaActividad(String nombreActividad, int cupoMaximo = 30)
        {
            if (!ExisteActividad(nombreActividad))
            {
                actividades.Add(new ActividadMati(nombreActividad, cupoMaximo));
                return true;
            }
            return false;
        }

        public String InscribirActividad(String nombreActividad, int idSocio)
        {
            SocioMati socio = ObtenerSocio(idSocio);
            ActividadMati actividad = ObtenerActividad(nombreActividad);
            string mensaje = "";

            if (socio == null)
            {
                mensaje = "SOCIO INEXISTENTE";
            }
            else if (actividad == null)
            {
                mensaje = "ACTIVIDAD INEXISTENTE";
            }

            else if (socio.CantidadActividadesInscriptas() >= MAX_ACTIVIDADES_POR_SOCIO)
            {
                mensaje = "TOPE DE ACTIVIDADES ALCANZADO";
            }
            else if (!actividad.HayCupo())
            {
                mensaje = "NO HAY CUPO PARA LA ACTIVIDAD";
            }
            else if (socio.InscribirActividad(actividad))
            {
                actividad.DescontarCupo();
                mensaje = "INSCRIPCIÓN EXITOSA";
            }
            else
            {
                mensaje = "EL SOCIO YA SE ENCUENTRA INSCRIPTO EN ESA ACTIVIDAD";
            }
            return mensaje;
        }

        bool ExisteSocio(int id)
        {
            SocioMati socio = socios.Find(s => s.Id == id);
            return socio != null;
        }

        bool ExisteActividad(string nombreActividad)
        {
            ActividadMati actividad = actividades.Find(a => a.Nombre == nombreActividad);
            return actividad != null;
        }

        SocioMati ObtenerSocio(int id)
        {
            return socios.Find(s => s.Id == id);
        }

        ActividadMati ObtenerActividad(string nombreActividad)
        {
            return actividades.Find(a => a.Nombre.ToLower() == nombreActividad.ToLower());
        }

    }
}

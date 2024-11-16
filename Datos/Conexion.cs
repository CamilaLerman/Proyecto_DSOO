using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Primer_Entrega_PI.Datos
{
    public class Conexion
    {
        //Declaramos las variables para los detalles de la conexion:
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        //Constructor:
        private Conexion()
        {
            this.baseDatos = "db_proyecto";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "79520801";

        }

        //Proceso de interacción:
        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                Console.WriteLine($" Error en la conexión: {ex.Message}");
                throw;
            }
            return cadena;
        }

        //Evaluar la instancia de la conectividad:
        public static Conexion Instancia
        {
            get
            {
                if (con == null)
                {
                    con = new Conexion();
                }
                return con;
            }
        }
    }
}

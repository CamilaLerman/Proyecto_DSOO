using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Entrega_PI.Datos
{
    internal class Socios
    {
        public DataTable BuscarSocioPorDocumento(string tipoDocumento, int documento)
        {
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.Instancia.CrearConexion();
                MySqlCommand comando = new MySqlCommand("BuscarSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("_TDocSocio", MySqlDbType.VarChar).Value = tipoDocumento;
                comando.Parameters.Add("_DocumentoSocio", MySqlDbType.Int32).Value = documento;

                sqlCon.Open();
                using (MySqlDataReader resultado = comando.ExecuteReader())
                {
                    tabla.Load(resultado);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error!: {ex.Message}");
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return tabla;

            }

        public DataTable ObtenerUltimaInscripcion()
        {
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.Instancia.CrearConexion();
                MySqlCommand comando = new MySqlCommand("GetInscripcion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();
                using (MySqlDataReader resultado = comando.ExecuteReader())
                {
                    tabla.Load(resultado);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error!: {ex.Message}");
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return tabla;

        }

    }
}
    

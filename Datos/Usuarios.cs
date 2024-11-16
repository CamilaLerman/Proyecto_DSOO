using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Entrega_PI.Datos
{
    internal class Usuarios
    {
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {

            // Se valida que el sistema no pase valores vacíos a la BBDD 
            if (string.IsNullOrEmpty(L_Usu) || string.IsNullOrEmpty(P_Usu))
            {
                throw new ArgumentException("El Usuario y la contraseña no pueden estar vacíos.");
            }


            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.Instancia.CrearConexion();

                MySqlCommand comando = new MySqlCommand("GetUsers", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Usuario", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Password", MySqlDbType.VarChar).Value = P_Usu;

                sqlCon.Open();

                resultado = comando.ExecuteReader();
                tabla.Load(resultado);

                return tabla;
            }
            catch (MySqlException mysqlEx)
            {
                Console.WriteLine($"Error en la BBDD MySql: {mysqlEx.Message}");
                throw;
            }

            catch (TimeoutException timeoutEx)
            {
                Console.WriteLine($"Error de tiempo de espera: {timeoutEx}");
                throw;
            }
            catch (ArgumentException argEx)
            {
                //Errores de argumentos, por ejemplo, si los parámetros proporcionados son inválidos:
                Console.WriteLine($"Error en los parámetros proporcionados: {argEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la base de datos MySQL: {ex.Message}");
                Console.WriteLine($"Strack Trace:{ex.StackTrace}");
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}

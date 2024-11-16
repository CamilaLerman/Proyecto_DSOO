using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Entrega_PI.Datos
{
    internal class AsignarCupo
    {
        public bool ActualizarCupo(int id_Clase)
        {
            bool exito = false;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.Instancia.CrearConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarInscriptos", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("_id_Clase", MySqlDbType.Int32).Value = id_Clase;

                sqlCon.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                exito = filasAfectadas > 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al gestionar inscripción", $"Falla al actualizar Cupo Disponible + {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return exito;
        }


        public int ModificarLista(int Id_Socio, int id_Clase)
        {
            int exito = 0;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.Instancia.CrearConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarLista", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("_Id_Socio", MySqlDbType.Int32).Value = Id_Socio;
                comando.Parameters.Add("_id_Clase", MySqlDbType.Int32).Value = id_Clase;

                sqlCon.Open();

                exito = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show( $"Falla al actualizar la Lista de Inscriptos {ex.Message}", "Error al gestionar inscripción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return exito;

        }




    }
}

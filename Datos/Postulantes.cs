using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Primer_Entrega_PI.Datos.Postulantes;

namespace Primer_Entrega_PI.Datos
{
    internal class Postulantes
    {
        public string Nuevo_Postu(Entidades.E_Postulante postu)
        {
            string? salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.Instancia.CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoPostulante", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("_NombrePostu", MySqlDbType.VarChar).Value = postu.NombrePostu;
                comando.Parameters.Add("_ApellidoPostu", MySqlDbType.VarChar).Value = postu.ApellidoPostu;
                comando.Parameters.Add("_TDocPostu", MySqlDbType.VarChar).Value = postu.TDocPostu;
                comando.Parameters.Add("_DocumentoPostu", MySqlDbType.Int32).Value = postu.DocumentoPostu;
                comando.Parameters.Add("_EsSocio", MySqlDbType.VarChar).Value = postu.EsSocio;
                comando.Parameters.Add("_Abono", MySqlDbType.VarChar).Value = postu.Abono;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);

                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }

        public DataTable BuscarNPostu(int _NPostu) 
        {
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.Instancia.CrearConexion();
                MySqlCommand comando = new MySqlCommand("BuscarPostulante", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("_Npostu", MySqlDbType.Int32).Value = _NPostu;

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


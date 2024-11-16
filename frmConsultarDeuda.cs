using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Ocsp;
using Primer_Entrega_PI.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Entrega_PI
{
    public partial class frmConsultarDeuda : Form
    {
        internal string? usuario;
        internal string? rol;
        public frmConsultarDeuda(string usuario, string rol)
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.usuario = usuario;
            this.rol = rol;

            // Limpiamos cualquier valor previo
            cboTipo.Items.Clear();

            // Agregamos los tipos de documentos disponibles
            cboTipo.Items.Add("DNI");
            cboTipo.Items.Add("Pasaporte");
            cboTipo.Items.Add("Libreta Cívica");
            cboTipo.Items.Add("Libreta de Enrolamiento");
            cboTipo.Items.Add("CUIL");

            cboTipo.SelectedIndex = -1;

        }

        //EVENTOS DEL BOTÓN "BUSCAR"
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboTipo.Text == "" || txtDocumento.Text == "")
            {
                MessageBox.Show("Debe completar tanto el TIPO de documento como el número del mismo","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string tipoDocumento = cboTipo.Text;
            int documento = Convert.ToInt32(txtDocumento.Text);
            
            CargarGrilla_Cuotas(tipoDocumento, documento);
        }

        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.DeepSkyBlue;
            btnBuscar.ForeColor = Color.White;

        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.WhiteSmoke;
            btnBuscar.ForeColor = Color.Black;

        }


        //EVENTOS DEL BOTÓN "VOLVER"
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmGestionPagos gestion = new frmGestionPagos(usuario, rol);
            gestion.Show();
            this.Hide();
        }

        private void btnVolver_MouseEnter(object sender, EventArgs e)
        {
            btnVolver.BackColor = Color.MediumSeaGreen;
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.BackColor = Color.WhiteSmoke;
        }


        //EVENTOS DEL BOTÓN "LIMPIAR"
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboTipo.SelectedIndex = -1;
            txtDocumento.Text = "";
            dtvgCuotasPendientes.Rows.Clear();

        }
        private void btnLimpiar_MouseEnter(object sender, EventArgs e)
        {
            btnLimpiar.BackColor = Color.DarkGray;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Size = new Size(btnLimpiar.Width + 5, btnLimpiar.Height + 5);
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.BackColor = Color.WhiteSmoke;
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Size = new Size(btnLimpiar.Width - 5, btnLimpiar.Height - 5);
        }


        //Método para buscar al socio y traer las cuotas pendientes de pago:
        public void CargarGrilla_Cuotas(string tipoDocumento, int documento)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.Instancia.CrearConexion();
                MySqlCommand comando = new MySqlCommand("BuscarCuotasSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("_TDocSocio", MySqlDbType.VarChar).Value = tipoDocumento;
                comando.Parameters.Add("_DocumentoSocio", MySqlDbType.Int32).Value = documento;

                sqlCon.Open();
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtvgCuotasPendientes.Rows.Add();
                        dtvgCuotasPendientes.Rows[renglon].Cells[0].Value = reader.GetInt32(0);
                        dtvgCuotasPendientes.Rows[renglon].Cells[1].Value = reader.GetInt32(1);
                        dtvgCuotasPendientes.Rows[renglon].Cells[2].Value = reader.GetString(2);
                        dtvgCuotasPendientes.Rows[renglon].Cells[3].Value = reader.GetDateTime(3).ToString("dd/MM/yyyy"); ;
                        dtvgCuotasPendientes.Rows[renglon].Cells[4].Value = reader.GetString(4);

                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para mostrar en la grilla");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

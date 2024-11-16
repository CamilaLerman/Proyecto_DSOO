using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Primer_Entrega_PI.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Entrega_PI
{
    public partial class frmCupos : Form
    {
        internal string? usuario;
        internal string? rol;
        private int id_Clase_Seleccionada = -1;
        

        public frmCupos(string usuario, string rol)
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

            CargaGrilla();
        }


        //EVENTOS DEL BOTÓN "VOLVER"
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal principal = new frmVentanaPrincipal(usuario, rol);
            principal.Show();
            this.Hide();
        }

        private void btnVolver_MouseEnter(object sender, EventArgs e)
        {
            btnVolver.BackColor = Color.MediumSeaGreen;
            btnVolver.Size = new Size(btnVolver.Width + 5, btnVolver.Height + 5);
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.BackColor = Color.WhiteSmoke;
            btnVolver.Size = new Size(btnVolver.Width - 5, btnVolver.Height - 5);
        }


        //EVENTOS DEL BOTÓN "LIMPIAR"
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = "";
            cboTipo.SelectedIndex = -1;
            cboTipo.Focus();

            lblNombre.Text = "";
            lblApellido.Text = "";
            lblId.Text = "";

            btnAceptar.Enabled = false;

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

        //EVENTOS DEL BOTÓN "BUSCAR"

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboTipo.Text == "" || txtDocumento.Text == "")
            {
                MessageBox.Show("Debe completar tanto el TIPO de documento como el número del mismo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string _TDocSocio = cboTipo.Text;
            int _DocumentoSocio = Convert.ToInt32(txtDocumento.Text);

            Socios socios = new Socios();
            DataTable datosSocio = socios.BuscarSocioPorDocumento(_TDocSocio, _DocumentoSocio);

            if (datosSocio.Rows.Count > 0)
            {
                lblNombre.Enabled = true;
                lblApellido.Enabled = true;
                lblId.Enabled = true;

                DataRow row = datosSocio.Rows[0];
                lblNombre.Text = $"Nombre: {row["Nombre"]}";
                lblApellido.Text = $"Apellido: {row["Apellido"]}";
                lblId.Text = $"ID Socio: {row["Id_Socio"]}";
                btnAceptar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontraron Socios con los datos proporcionados.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLimpiar_Click(sender, e);
            }
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

        //EVENTOS BOTÓN "VER ÚLTIMA INSCRIPCIÓN":

        private void btnTraerDatos_Click(object sender, EventArgs e)
        {
            Socios socio = new Socios();
            DataTable ultimaInscripcion = socio.ObtenerUltimaInscripcion();

            if (ultimaInscripcion.Rows.Count > 0)
            {
                lblNombre.Enabled = true;
                lblApellido.Enabled = true;
                lblId.Enabled = true;
                btnAceptar.Enabled = true;

                DataRow row = ultimaInscripcion.Rows[0];
                lblNombre.Text = $"Nombre: {row["Nombre"]}";
                lblApellido.Text = $"Apellido: {row["Apellido"]}";
                lblId.Text = $"ID Socio: {row["Id_Socio"]}";
                cboTipo.Text = $"{row["Tipo"]}";
                txtDocumento.Text = $"{row["Documento"]}";


            }
            else
            {
                MessageBox.Show("Error", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLimpiar_Click(sender, e);
            }

        }

        private void btnTraerDatos_MouseEnter(object sender, EventArgs e)
        {

            btnTraerDatos.BackColor = Color.MediumSeaGreen;
            btnTraerDatos.ForeColor = Color.White;

        }

        private void btnTraerDatos_MouseLeave(object sender, EventArgs e)
        {
            btnTraerDatos.BackColor = Color.WhiteSmoke;
            btnTraerDatos.ForeColor = Color.Black;

        }


        private void dtvgActividad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dtvgActividad.Rows[e.RowIndex];
                id_Clase_Seleccionada = Convert.ToInt32(filaSeleccionada.Cells["Id_Clase"].Value);
            }
        }

        //EVENTOS BOTÓN "ACEPTAR"

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (id_Clase_Seleccionada < 0)
            {
                MessageBox.Show("Por favor, seleccione una actividad en la grilla antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int Id_Socio = Convert.ToInt32(lblId.Text.Replace("ID Socio: ", ""));

                AsignarCupo asignacion = new AsignarCupo();

                if (asignacion.ActualizarCupo(id_Clase_Seleccionada))
                {
                    int Lista = asignacion.ModificarLista(Id_Socio, id_Clase_Seleccionada);

                    if (Lista > 0)
                    { 

                        MessageBox.Show($"Actividad asignada con éxito al socio {Id_Socio}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }

            btnComprobante.Enabled = true;

        }

        private void btnAceptar_MouseEnter(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.Teal;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Size = new Size(btnAceptar.Width + 5, btnAceptar.Height + 5);
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.WhiteSmoke;
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Size = new Size(btnAceptar.Width - 5, btnAceptar.Height - 5);
        }


        //EVENTOS BOTÓN " COMPROBANTE":
        private void btnComprobante_Click(object sender, EventArgs e)
        {
            if (dtvgActividad.SelectedRows.Count > 0)
            {
                string nombreSocio = lblNombre.Text;
                string apellidoSocio = lblApellido.Text;

                DataGridViewRow filaSeleccionada = dtvgActividad.SelectedRows[0];

                // Extraer los datos de la actividad desde la grilla
                string actividad = filaSeleccionada.Cells["Nombre"].Value?.ToString() ?? "";
                string dia = filaSeleccionada.Cells["Dia"].Value?.ToString() ?? "";
                string horario = filaSeleccionada.Cells["Horario"].Value?.ToString() ?? "";
                string profesor = filaSeleccionada.Cells["Profesor"].Value?.ToString() ?? "";

                frmComprobanteInscripcion inscripcion = new frmComprobanteInscripcion(
                    usuario, rol, nombreSocio, apellidoSocio, actividad, dia, horario, profesor
                );

                inscripcion.Show();
                this.Hide();

            }
        }


        //Método para buscar y traer los datos de las actividades de la BBDD:
        public void CargaGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.Instancia.CrearConexion();
                MySqlCommand comando = new MySqlCommand("GetActividades", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtvgActividad.Rows.Add();
                        dtvgActividad.Rows[renglon].Cells[0].Value = reader.GetInt32(0);
                        dtvgActividad.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dtvgActividad.Rows[renglon].Cells[2].Value = reader.GetInt32(2);
                        dtvgActividad.Rows[renglon].Cells[3].Value = reader.GetFloat(3);
                        dtvgActividad.Rows[renglon].Cells[4].Value = reader.GetString(4);
                        dtvgActividad.Rows[renglon].Cells[5].Value = reader.GetString(5);
                        dtvgActividad.Rows[renglon].Cells[6].Value = reader.GetString(6);
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

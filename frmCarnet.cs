using MySql.Data.MySqlClient;
using Primer_Entrega_PI.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Entrega_PI
{
    public partial class frmCarnet : Form
    {
        internal string? usuario;
        internal string? rol;
        public frmCarnet(string usuario, string rol)
        {
            InitializeComponent();
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

        //EVENTOS DEL CBO "TIPO"
        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
        }


        //EVENTOS DEL BOTÓN "BUSCAR"
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboTipo.Text != "" && txtDocumento.Text != "")
            {
                string tipoDocumento = cboTipo.Text;
                int documento = Convert.ToInt32(txtDocumento.Text);

                MySqlConnection sqlCon = new MySqlConnection();
                try
                {
                    sqlCon = Conexion.Instancia.CrearConexion();
                    MySqlCommand comando = new MySqlCommand("GetDatosCarnet", sqlCon);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("_TDocSocio", MySqlDbType.VarChar).Value = tipoDocumento;
                    comando.Parameters.Add("_DocumentoSocio", MySqlDbType.Int32).Value = documento;

                    sqlCon.Open();
                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtIdSocio.Text = reader["ID_Socio"].ToString();
                        txtNombre.Text = reader["Nombre"].ToString();
                        txtApellido.Text = reader["Apellido"].ToString();
                        txtAbono.Text = reader["Abono"].ToString();

                        // Mostrar los campos de ID Socio y Abono
                        lblId.Visible = true;
                        txtIdSocio.Visible = true;
                        lblAbono.Visible = true;
                        txtAbono.Visible = true;
                        lblNombre.Visible = true;
                        txtNombre.Visible = true;
                        lblApellido.Visible = true;
                        txtApellido.Visible = true;

                        // Habilitar el botón Imprimir
                        btnImprimir.Enabled = true;
                        btnLimpiar.Enabled = true;
                        btnBuscar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un socio con los datos ingresados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimpiar.Enabled=true;
                        btnBuscar.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar el socio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnLimpiar_Click(sender,e);
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

            //EVENTOS BOTÓN "VOLVER":
            private void btnVolver_Click(object sender, EventArgs e)
            {
                frmVentanaPrincipal menu = new frmVentanaPrincipal(usuario, rol);
                menu.Show();
                this.Close();

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

            //EVENTOS BOTÓN "IMPRIMIR":
            private void btnImprimir_Click(object sender, EventArgs e)
            {
                btnImprimir.Visible = false;
                btnVolver.Visible = false;
                lblAviso.Visible = false;
                btnLimpiar.Visible = false;
                btnBuscar.Visible = false;
                lblAsterisco.Visible = false;
                lblAsterisco2.Visible = false;


                PrintDocument printDocument = new PrintDocument();
                printDocument.DefaultPageSettings.Landscape = false;
                printDocument.PrintPage += new PrintPageEventHandler(ImprimirCarnet);
                printDocument.Print();

                btnImprimir.Visible = true;
                lblAviso.Visible = true;
                MessageBox.Show("Aviso del Sistema", "Carnet impreso con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnVolver_Click(sender, e);
            }

            private void btnImprimir_MouseEnter(object sender, EventArgs e)
            {
                btnImprimir.BackColor = Color.ForestGreen;
                btnImprimir.ForeColor = Color.White;
            }

            private void btnImprimir_MouseLeave(object sender, EventArgs e)
            {
                btnImprimir.BackColor = Color.WhiteSmoke;
                btnImprimir.ForeColor = Color.Black;
            }


            //Conjunto de sentencias necesarias para el objeto print:

            private void ImprimirCarnet(object o, PrintPageEventArgs e)
            {
                int anchoPagina = e.PageBounds.Width;
                int altoPagina = e.PageBounds.Height;

                Bitmap img = new Bitmap(this.Width, this.Height);
                this.DrawToBitmap(img, new Rectangle(0, 0, this.Width, this.Height));

                float X = (float)anchoPagina / (float)img.Width;
                float Y = (float)anchoPagina / (float)img.Height;
                float scale = Math.Min(X, Y);

                float posX = (anchoPagina - (img.Width * scale)) / 2;
                float posY = (altoPagina - (img.Height * scale)) / 2;

                e.Graphics.DrawImage(img, posX, posY, img.Width * scale, img.Height * scale);

            }

            //EVENTOS DEL BOTÓN "LIMPIAR"
            private void btnLimpiar_Click(object sender, EventArgs e)
            {
                lblAbono.Enabled = false;
                txtAbono.Visible = false;
                lblNombre.Enabled = false;
                txtNombre.Visible = false;
                lblApellido.Enabled = false;
                txtApellido.Visible =false;
                lblId.Enabled = false;
                txtIdSocio.Visible = false;
                cboTipo.SelectedIndex = -1;
                txtDocumento.Text = "";
                btnImprimir.Enabled = false;
                btnLimpiar.Enabled = false;
                btnBuscar.Enabled = false;
                

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

        }
    }

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
    public partial class frmListadoVencimientos : Form
    {
        internal string? usuario;
        internal string? rol;

        public frmListadoVencimientos(string usuario, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;

            
        }

        public void frmListadoVencimientos_Load(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha:" + DateTime.Now.ToString("dd/MM/yy");
            CargarGrillaVencimientos();
        }

        public void CargarGrillaVencimientos()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.Instancia.CrearConexion();
                MySqlCommand comando = new MySqlCommand("BuscarVencimientos", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtvgListadoVencimientos.Rows.Add();

                        dtvgListadoVencimientos.Rows[renglon].Cells[0].Value = reader.GetInt32(0);
                        dtvgListadoVencimientos.Rows[renglon].Cells[1].Value = reader.GetInt32(1);
                        dtvgListadoVencimientos.Rows[renglon].Cells[2].Value = reader.GetString(2);
                        dtvgListadoVencimientos.Rows[renglon].Cells[3].Value = reader.GetDateTime(3).ToString("dd/MM/yyyy");
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


        //EVENTOS BOTÓN "IMPRIMIR"
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            btnVolver.Visible = false;
            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.Landscape = false;
            printDocument.PrintPage += new PrintPageEventHandler(ImprimirListado);
            printDocument.Print();

            MessageBox.Show("Comprobante impreso con éxito", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnImprimir.Visible = true;
            btnVolver.Visible=true;
        }

        //Conjunto de sentencias necesarias para el objeto print:
        private void ImprimirListado(object o, PrintPageEventArgs e)
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

        //EVENTOS BOTÓN "VOLVER"
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmGestionPagos gestion = new frmGestionPagos(usuario, rol);
            gestion.Show();
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
    }
}



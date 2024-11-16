using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Entrega_PI
{
    public partial class frmFactura : Form
    {
        internal string? usuario;
        internal string? rol;
        public frmFactura(string usuario, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;
        }

        public string? socio_f;
        public string? actividad_f;
        public string? forma_f;
        public float monto_f;
        public int numero_f;
        public DateTime fecha_f;
        public int id_incripcion_f;

        //EVENTOS BOTÓN "VOLVER"
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

        //EVENTOS BOTÓN "IMPRIMIR"
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            btnVolver.Visible = false;
            lblAviso.Visible = false;


            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.Landscape = false;
            printDocument.PrintPage += new PrintPageEventHandler(ImprimirFactura);
            printDocument.Print();

            btnImprimir.Visible = true;
            lblAviso.Visible = true;
            MessageBox.Show("Aviso del Sistema", "Comprobante impreso con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ImprimirFactura(object o, PrintPageEventArgs e)
        {
            int anchoPagina = e.PageBounds.Width;
            int altoPagina = e.PageBounds.Height;
            
            Bitmap img = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(img,new Rectangle (0,0, this.Width, this.Height));

            float X = (float)anchoPagina/(float)img.Width;
            float Y = (float)anchoPagina/(float)img.Height;
            float scale = Math.Min(X, Y);

            float posX = (anchoPagina - (img.Width * scale)) / 2;
            float posY = (altoPagina - (img.Height * scale)) / 2;

            e.Graphics.DrawImage(img,posX, posY, img.Width*scale, img.Height*scale);

        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            lblNombre.Text = $"Nombre: {socio_f}";
            lblActividad.Text = $"Actividad Abonada: {actividad_f}";
            lblFechaInscripcion.Text = $"Fecha de Inscripción: {fecha_f}";
            lblMetodoPago.Text = $"Método de Pago: {forma_f}";
            lblMonto.Text = $"Monto: ${monto_f}";
            lblFecha.Text = "Fecha de Pago: " + DateTime.Now.ToString("dd/MM/yy");
        }
    }
}

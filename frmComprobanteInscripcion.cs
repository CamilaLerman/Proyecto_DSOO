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
    public partial class frmComprobanteInscripcion : Form
    {
        private string? actividad;
        private string? apellido;
        private string? dia;
        private string? horario;
        private string? nombre;
        private string? profesor;
        internal string? rol;
        internal string? usuario;



        public frmComprobanteInscripcion(string usuario, string rol, string nombreSocio, string apellidoSocio,
            string actividad, string dia, string horario, string profesor)
        {
            InitializeComponent();
            this.actividad = actividad;
            this.apellido = apellidoSocio;
            this.dia = dia;
            this.horario = horario;
            this.nombre = nombreSocio;
            this.profesor = profesor;
            this.rol = rol;
            this.usuario = usuario;
            this.BackColor = Color.LightGray;
        }



        private void frmComprobanteInscripcion_Load(object sender, EventArgs e)
        {
            lblActividad.Text = $"Actividad Inscripta: {actividad}";
            lblApellido.Text = $"{apellido}";
            lblNombre.Text = $"{nombre}";
            lblHorario.Text = $"Horario: {dia}, {horario} hs.";
            lblProfesor.Text = $"Profesor: {profesor}";

        }

        //EVENTOS BOTÓN "IMPRIMIR":
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            btnVolver.Visible = false;
            lblAviso.Visible = false;


            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.Landscape = false;
            printDocument.PrintPage += new PrintPageEventHandler(ImprimirInscripcionActividad);
            printDocument.Print();

            btnImprimir.Visible = true;
            btnVolver.Visible = true;
            lblAviso.Visible=true;
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

        private void ImprimirInscripcionActividad(object o, PrintPageEventArgs e)
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
    }
}

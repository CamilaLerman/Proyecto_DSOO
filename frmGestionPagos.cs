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
    public partial class frmGestionPagos : Form
    {
        internal string? usuario;
        internal string? rol;

        public frmGestionPagos(string usuario, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;
            this.BackColor = Color.White;

            //Configuración general de botones:

            ConfigurarBoton(btnConsultarDeuda);
            ConfigurarBoton(btnPagar);
            ConfigurarBoton(btnListadoVencimiento);


        }

        private void frmPagar_Load(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha:" + DateTime.Now.ToString("dd/MM/yy");
            lblUsuario.Text = $"USUARIO: {usuario} ({rol})";
        }

        private void ConfigurarBoton(Button btn)
        {
            btn.BackColor = Color.FromArgb(2, 104, 115);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            btn.MouseEnter += Boton_MouseEnter;
            btn.MouseLeave += Boton_MouseLeave;
        }


        //Evento general: El mouse entra en el botón
        private void Boton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Black;
            btn.BackColor = Color.FromArgb(242, 227, 213);
            btn.FlatStyle = FlatStyle.Popup;
            btn.Size = new Size(btn.Width + 5, btn.Height + 5);

        }

        //Evento general: El mouse sale del botón
        private void Boton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.White;
            btn.BackColor = Color.FromArgb(2, 104, 115);
            btn.FlatStyle = FlatStyle.Flat;
            btn.Size = new Size(btn.Width - 5, btn.Height - 5);
        }


        // EVENTOS BOTON "VOLVER":
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


        // EVENTOS BOTON "CERRAR SESION":

        private void btnCerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            btnCerrarSesion.BackColor = Color.FromArgb(50, 150, 255);
            btnCerrarSesion.Size = new Size(btnCerrarSesion.Width + 5, btnCerrarSesion.Height + 5);
            btnCerrarSesion.ForeColor = Color.White;
        }

        private void btnCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarSesion.BackColor = Color.WhiteSmoke;
            btnCerrarSesion.Size = new Size(btnCerrarSesion.Width - 5, btnCerrarSesion.Height - 5);
            btnCerrarSesion.ForeColor = Color.Black;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //Vuelve a la ventana de Login: 

            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();

            //Si se cierra la ventan de Login se cierra toda la aplicación.
            login.FormClosed += (s, arg) => this.Close();
        }


        //EVENTOS BOTÓN "PAGAR"
        private void btnPagar_Click(object sender, EventArgs e)
        {
            frmPagar pagar = new frmPagar(usuario, rol);
            pagar.Show();
            this.Hide();

        }

        private void btnListadoVencimiento_Click(object sender, EventArgs e)
        {
            frmListadoVencimientos listado = new frmListadoVencimientos(usuario, rol);
            listado.Show();
            this.Hide();
        }

        private void btnConsultarDeuda_Click(object sender, EventArgs e)
        {
            frmConsultarDeuda consultarDeuda = new frmConsultarDeuda(usuario,rol);
            consultarDeuda.Show();
            this.Hide();
        }
    }
}
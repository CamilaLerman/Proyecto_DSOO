using MySqlX.XDevAPI.Relational;
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
    public partial class frmInscripcion : Form
    {
        internal string? usuario;
        internal string? rol;
        public frmInscripcion(string usuario, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;
            this.BackColor = Color.White;

            // Limpiamos cualquier valor previo
            cboTipo.Items.Clear();
            cboSocio.Items.Clear();

            // Agregamos los tipos de documentos disponibles
            cboTipo.Items.Add("DNI");
            cboTipo.Items.Add("Pasaporte");
            cboTipo.Items.Add("Libreta Cívica");
            cboTipo.Items.Add("Libreta de Enrolamiento");
            cboTipo.Items.Add("CUIL");

            //Agregamos las opciones para Socio:
            cboSocio.Items.Add("Sí");
            cboSocio.Items.Add("No");

            //Agregamos las opciones para Abono:
            cboAbono.Items.Add("Mensual");
            cboAbono.Items.Add("Bimestral");
            cboAbono.Items.Add("Trimestral");
            cboAbono.Items.Add("Semestral");
            cboAbono.Items.Add("Anual");

            cboTipo.SelectedIndex = -1;
            cboSocio.SelectedIndex = -1;
            cboAbono.SelectedIndex = -1;

        }

        //EVENTOS BOTÓN "VOLVER":
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

        //EVENTOS BOTÓN "LIMIPAR":
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            cboSocio.SelectedIndex = -1;
            cboTipo.SelectedIndex = -1;
            cboAbono.SelectedIndex = -1;
            txtNombre.Focus();
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


        //EVENTOS BOTÓN "INGRESAR":
        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.Teal;
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Size = new Size(btnIngresar.Width + 5, btnIngresar.Height + 5);
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.WhiteSmoke;
            btnIngresar.ForeColor = Color.Black;
            btnIngresar.Size = new Size(btnIngresar.Width - 5, btnIngresar.Height - 5);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" ||
                txtDocumento.Text == "" || cboTipo.Text == "" ||
                cboSocio.Text == "" || (cboSocio.Text == "Sí" && cboAbono.Text == ""))
            {
                MessageBox.Show("Debe completar los datos requeridos (*)",
                    "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string respuesta;
                Entidades.E_Postulante postu = new Entidades.E_Postulante();
                postu.NombrePostu = txtNombre.Text;
                postu.ApellidoPostu = txtApellido.Text;
                postu.DocumentoPostu = Convert.ToInt32(txtDocumento.Text);
                postu.TDocPostu = cboTipo.Text;
                postu.EsSocio = cboSocio.Text;
                postu.Abono = cboAbono.Text;


                Datos.Postulantes postulantes = new Datos.Postulantes();

                respuesta = postulantes.Nuevo_Postu(postu);

                bool esnumero = int.TryParse(respuesta, out int codigo);

                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("Miembro Existente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Nuevo Miembro agregado con exito, su código es Nro. {respuesta}", "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                            MessageBoxIcon.Question);
                        btnLimpiar_Click(sender, e);
                    }
                }
            }
        }

        //EVENTO COMBO BOX "Abono":
       private void cboSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSocio.SelectedIndex == 0)
            {
                lblAbono.Enabled = true;
                cboAbono.Enabled = true;
                lblAsteriscoAbono.Visible = true;
            }
            else
            {
                lblAbono.Enabled = false;
                cboAbono.Enabled = false;
                lblAsteriscoAbono.Visible = false;
            }
        }
    }
}

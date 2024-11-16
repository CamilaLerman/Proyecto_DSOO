using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;

namespace Primer_Entrega_PI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.BackColor = Color.White;

        }

        //EVENTOS CAMPO "USUARIO":
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.BackColor = Color.WhiteSmoke;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.BackColor = Color.WhiteSmoke;
            }
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();

        }

        //EVENTOS CAMPO "CONSTRASEÑA":
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
                txtPass.BackColor = Color.WhiteSmoke;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
                txtPass.BackColor = Color.WhiteSmoke;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }


        private void ValidarCampos()
        {
            //Se valida que los campos de usuario y contraseña no estén vacíos para habilitar el botón de "Ingresar".

            btnIngresar.Enabled = (!string.IsNullOrEmpty(txtUsuario.Text) &&
                                   txtUsuario.Text != "USUARIO" &&
                                   !string.IsNullOrEmpty(txtPass.Text) &&
                                   txtPass.Text != "CONTRASEÑA");

        }


        //EVENTO CHECK "MOSTRAR" para mostrar u ocultar contraseña:
        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            chkMostrarPass.ForeColor = Color.FromArgb(52, 58, 64);

            if (txtPass.Text != "CONTRASEÑA")
            {
                if (chkMostrarPass.Checked)
                {

                    txtPass.UseSystemPasswordChar = false; //Se muestra la contraseña. 

                }
                else
                {
                    txtPass.UseSystemPasswordChar = true; // Se esconde la contraseña
                }
            }
        }

        //EVENTOS BOTÓN "INGRESAR";

        //Efectos al pasar el mouse sobre el botón:
        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.FromArgb(50, 150, 255);
            btnIngresar.Size = new Size(btnIngresar.Width + 5, btnIngresar.Height + 5);
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.WhiteSmoke;
            btnIngresar.Size = new Size(btnIngresar.Width - 5, btnIngresar.Height - 5);
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();

            //Se llama al método que hace la consulta a la BBDD 
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                //Extraemos los valores del usuario y su rol:
                string usuario = Convert.ToString(txtUsuario.Text);
                string rol = Convert.ToString(tablaLogin.Rows[0]["Rol"]) ?? "Sin Rol";

                MessageBox.Show("Ingreso exitoso");

                //Pasamos los datos de usuario y rol al Form de Ventana Principal:
                frmVentanaPrincipal ventanaPrincipal = new frmVentanaPrincipal(usuario, rol);

                //Mostramos la Ventana Principal y ocultamos el Login
                ventanaPrincipal.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }


        }

        //Evento para ingresar al presionar Enter en el campo "Contraseña"
        private void btnIngresar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtUsuario.Text) && txtUsuario.Text != "USUARIO" &&
                    !string.IsNullOrEmpty(txtPass.Text) && txtPass.Text != "CONTRASEÑA")
                {
                    btnIngresar_Click(sender, e); // Llamada al evento de ingresar.
                }
                else
                {
                    MessageBox.Show("Por favor, complete ambos campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = true; // Evita que el evento continúe.
                e.SuppressKeyPress = true; // Evita que suene un 'beep' en la caja de texto.
            }
        }
    }
}


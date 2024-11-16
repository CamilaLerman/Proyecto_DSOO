using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Primer_Entrega_PI
{
    public partial class frmPagar : Form
    {
        internal string? usuario;
        internal string? rol;

        public frmFactura doc;


        public frmPagar(string usuario, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;
            this.BackColor = Color.White;

            doc= new frmFactura(usuario,rol);

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

        //EVENTOS BOTÓN "BUSCAR":

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


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNPostu.Text == "" && (cboTipo.Text == "" && txtDocumento.Text == ""))
            {
                MessageBox.Show("Por favor, complete el número de inscripción o el tipo y número de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!(txtNPostu.Text == ""))
                {
                    int _NPostu = Convert.ToInt32(txtNPostu.Text);

                    Postulantes postulante = new Postulantes();
                    DataTable datosPostulante = postulante.BuscarNPostu(_NPostu);

                    if (datosPostulante.Rows.Count > 0)
                    {
                        string nombre = datosPostulante.Rows[0]["Nombre"].ToString();
                        string apellido = datosPostulante.Rows[0]["Apellido"].ToString();
                        string tipo = datosPostulante.Rows[0]["Tipo"].ToString();
                        string documento = datosPostulante.Rows[0]["Documento"].ToString();


                        DialogResult result = MessageBox.Show($"Socio Seleccionado: {nombre}, {apellido}\n\n¿Es correcto?", "Confirmación de Socio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            btnPagar.Enabled = true;
                            cboTipo.Text = tipo;
                            txtDocumento.Text = documento;
                        }
                        else
                        {
                            btnLimpiar_Click(sender, e);
                        }
                    }
                }
                else if (!(cboTipo.Text == "" && txtDocumento.Text == ""))
                {
                    string _TDocSocio = cboTipo.Text;
                    int _DocumentoSocio = Convert.ToInt32(txtDocumento.Text);

                    Socios socios = new Socios();
                    DataTable datosSocio = socios.BuscarSocioPorDocumento(_TDocSocio, _DocumentoSocio);

                    if (datosSocio.Rows.Count > 0)
                    {
                        string nombre = datosSocio.Rows[0]["Nombre"].ToString();
                        string apellido = datosSocio.Rows[0]["Apellido"].ToString();
                        string numPostulante = datosSocio.Rows[0]["NPostu"].ToString();

                        DialogResult result = MessageBox.Show($"Socio Seleccionado: {nombre}, {apellido}\n\n¿Es correcto?", "Confirmación de Socio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            btnPagar.Enabled = true;
                            txtNPostu.Text = numPostulante;
                        }
                        else
                        {
                            btnLimpiar_Click(sender, e);
                        }
                    }

                }

            }
        }

        //EVENTOS DEL BOTÓN "VOLVER":
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmGestionPagos gestion = new frmGestionPagos(usuario, rol);
            gestion.Show();
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

        //EVENTOS DEL BOTÓN "LIMPIAR"

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNPostu.Text = "";
            txtDocumento.Text = "";
            cboTipo.SelectedIndex = -1;
            btnPagar.Enabled = false;

            txtNPostu.Focus();
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

        //EVENTOS DEL BOTÓN "COMPROBANTE"

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            doc.Show();
            this.Hide();
        }

        private void btnComprobante_MouseEnter(object sender, EventArgs e)
        {
            btnComprobante.BackColor = Color.Teal;
            btnComprobante.ForeColor = Color.White;
            btnComprobante.Size = new Size(btnComprobante.Width + 5, btnComprobante.Height + 5);
        }

        private void btnComprobante_MouseLeave(object sender, EventArgs e)
        {
            btnComprobante.BackColor = Color.WhiteSmoke;
            btnComprobante.ForeColor = Color.Black;
            btnComprobante.Size = new Size(btnComprobante.Width - 5, btnComprobante.Height - 5);
        }


        //EVENTOS DEL BOTÓN "PAGAR"
        private void btnPagar_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.Instancia.CrearConexion();
                query = ("SELECT a.nomActividad, CONCAT_WS(' ', p.NombrePostu, p.ApellidoPostu) AS NombreSocio,a.precio,i.fecha, i.idInscri\r\nFROM actividad AS a\r\nINNER JOIN edicion AS e ON a.idActividad = e.idActividad\r\nINNER JOIN lista AS l ON e.idEdicion = l.idEdicion\r\nINNER JOIN socios AS s ON l.idSocio = s.idSocio\r\nINNER JOIN postulante AS p ON s.Npostu = p.Npostu\r\nINNER JOIN inscripcion AS i ON l.idLista = i.idLista\r\nWHERE s.Npostu = " + txtNPostu.Text);

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    doc.actividad_f = reader.GetString(0);
                    doc.socio_f = reader.GetString(1);
                    doc.monto_f = (float)Convert.ToDouble(reader.GetString(2));
                    doc.fecha_f = (DateTime)Convert.ToDateTime(reader.GetString(3));
                    doc.id_incripcion_f=Convert.ToInt32(reader.GetString(4));

                    if (rbEfectivo.Checked == true)
                    {
                        doc.forma_f = "Efectivo";
                        doc.monto_f = (float)(doc.monto_f * 0.90);
                        btnComprobante.Enabled = true;
                    }
                    else if (rbDebito.Checked == true)
                    {
                        doc.forma_f = "Tarjeta de Débito / Transferencia.";
                        btnComprobante.Enabled = true;
                    }
                    else if (rbTarjetaCredito.Checked == true)
                    {
                        doc.forma_f = "Tarjeta de Crédito";
                        doc.monto_f = (float)(doc.monto_f * 0.90); doc.monto_f = (float)(doc.monto_f * 1.10);
                        btnComprobante.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Error", "Por favor seleccione un Método de Pago.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    reader.Close();

                    MySqlCommand actualizarPagoCmd = new MySqlCommand("ActualizarPagos", sqlCon);

                    actualizarPagoCmd.CommandType = CommandType.StoredProcedure;

                    actualizarPagoCmd.Parameters.Add("_id_Inscripcion", MySqlDbType.Int32).Value = doc.id_incripcion_f;
                    actualizarPagoCmd.Parameters.Add("_monto", MySqlDbType.Float).Value = doc.monto_f;

                    actualizarPagoCmd.ExecuteNonQuery();

                    MessageBox.Show("Pago Exitoso", "El pago se ha realizado con éxito.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pbCheckPago.Visible = true;
                    btnPagar.Text = "PAGADO";

                }
                else
                {
                    MessageBox.Show("Número de Postulante inexistente.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje del CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void btnPagar_MouseEnter(object sender, EventArgs e)
        {
            btnPagar.BackColor = Color.MediumSeaGreen;
            btnPagar.ForeColor = Color.White;
        }

        private void btnPagar_MouseLeave(object sender, EventArgs e)
        {
            btnPagar.BackColor = Color.WhiteSmoke;
            btnPagar.ForeColor = Color.Black;
        }
    }
}

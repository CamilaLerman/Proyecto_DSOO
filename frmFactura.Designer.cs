namespace Primer_Entrega_PI
{
    partial class frmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            panel1 = new Panel();
            lblTitulo = new Label();
            panel2 = new Panel();
            lblHorarios = new Label();
            lblContacto = new Label();
            panel3 = new Panel();
            lblMonto = new Label();
            lblMetodoPago = new Label();
            lblFecha = new Label();
            lblFechaInscripcion = new Label();
            lblActividad = new Label();
            lblNombre = new Label();
            btnImprimir = new Button();
            btnVolver = new Button();
            pbLogo = new PictureBox();
            lblAviso = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(263, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 78);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(93, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(326, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Comprobante de Pago";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HighlightText;
            panel2.Controls.Add(lblHorarios);
            panel2.Controls.Add(lblContacto);
            panel2.Location = new Point(263, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(525, 139);
            panel2.TabIndex = 1;
            // 
            // lblHorarios
            // 
            lblHorarios.AutoSize = true;
            lblHorarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHorarios.Location = new Point(14, 7);
            lblHorarios.Name = "lblHorarios";
            lblHorarios.Size = new Size(195, 51);
            lblHorarios.TabIndex = 4;
            lblHorarios.Text = "Horarios de Atención:\r\nLunes a Viernes 8:00hs a 21:00hs.\r\nSábados : 08:00 a 14:00hs\r\n";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(15, 70);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(343, 68);
            lblContacto.TabIndex = 2;
            lblContacto.Text = "Para Consultas: \r\nTeléfono (011) 1234-5678\r\nCorreo electrónico : contacto@deportivoclubsistema.com\r\n\r\n";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HighlightText;
            panel3.Controls.Add(lblMonto);
            panel3.Controls.Add(lblMetodoPago);
            panel3.Controls.Add(lblFecha);
            panel3.Controls.Add(lblFechaInscripcion);
            panel3.Controls.Add(lblActividad);
            panel3.Controls.Add(lblNombre);
            panel3.Location = new Point(12, 241);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 168);
            panel3.TabIndex = 2;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonto.Location = new Point(241, 108);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(64, 17);
            lblMonto.TabIndex = 5;
            lblMonto.Text = "Monto  $";
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetodoPago.Location = new Point(24, 108);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(110, 17);
            lblMetodoPago.TabIndex = 4;
            lblMetodoPago.Text = "Método de Pago";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(487, 108);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(97, 17);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha de Pago";
            // 
            // lblFechaInscripcion
            // 
            lblFechaInscripcion.AutoSize = true;
            lblFechaInscripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaInscripcion.Location = new Point(483, 37);
            lblFechaInscripcion.Name = "lblFechaInscripcion";
            lblFechaInscripcion.Size = new Size(133, 17);
            lblFechaInscripcion.TabIndex = 3;
            lblFechaInscripcion.Text = "Fecha de Inscripción";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActividad.Location = new Point(242, 37);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(125, 17);
            lblActividad.TabIndex = 2;
            lblActividad.Text = "Actividad Abonada";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(24, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(713, 418);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            btnImprimir.MouseEnter += btnImprimir_MouseEnter;
            btnImprimir.MouseLeave += btnImprimir_MouseLeave;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 418);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseEnter += btnVolver_MouseEnter;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(245, 223);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.BackColor = SystemColors.Window;
            lblAviso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAviso.ForeColor = SystemColors.InactiveCaptionText;
            lblAviso.Location = new Point(164, 422);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(457, 15);
            lblAviso.TabIndex = 3;
            lblAviso.Text = "**Este es un comprobante de pago generado. Revise los detalles antes de imprimir**";
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(lblAviso);
            Controls.Add(btnImprimir);
            Controls.Add(pbLogo);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmFactura";
            Text = "FACTURA";
            Load += frmFactura_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Panel panel2;
        private Label lblContacto;
        private Label lblFecha;
        private PictureBox pbLogo;
        private Panel panel3;
        private Label lblMonto;
        private Label lblMetodoPago;
        private Label lblFechaInscripcion;
        private Label lblActividad;
        private Label lblNombre;
        private Button btnImprimir;
        private Button btnVolver;
        private Label lblAviso;
        private Label lblHorarios;
    }
}
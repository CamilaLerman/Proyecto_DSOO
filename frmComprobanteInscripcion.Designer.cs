namespace Primer_Entrega_PI
{
    partial class frmComprobanteInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprobanteInscripcion));
            pbLogo = new PictureBox();
            panel2 = new Panel();
            lblApellido = new Label();
            lblProfesor = new Label();
            lblHorario = new Label();
            lblNombre = new Label();
            lblActividad = new Label();
            lblHorarios = new Label();
            lblContacto = new Label();
            panel1 = new Panel();
            lblTitulo = new Label();
            panel3 = new Panel();
            btnImprimir = new Button();
            btnVolver = new Button();
            lblAviso = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(15, 36);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(239, 223);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HighlightText;
            panel2.Controls.Add(lblApellido);
            panel2.Controls.Add(lblProfesor);
            panel2.Controls.Add(lblHorario);
            panel2.Controls.Add(lblNombre);
            panel2.Controls.Add(lblActividad);
            panel2.Location = new Point(263, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 139);
            panel2.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(238, 6);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 17);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfesor.Location = new Point(238, 49);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(60, 17);
            lblProfesor.TabIndex = 5;
            lblProfesor.Text = "Profesor";
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHorario.Location = new Point(7, 95);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(136, 17);
            lblHorario.TabIndex = 4;
            lblHorario.Text = "Horario de Actividad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(7, 6);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActividad.Location = new Point(7, 49);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(66, 17);
            lblActividad.TabIndex = 2;
            lblActividad.Text = "Actividad";
            // 
            // lblHorarios
            // 
            lblHorarios.AutoSize = true;
            lblHorarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHorarios.Location = new Point(10, 6);
            lblHorarios.Name = "lblHorarios";
            lblHorarios.Size = new Size(195, 51);
            lblHorarios.TabIndex = 4;
            lblHorarios.Text = "Horarios de Atención:\r\nLunes a Viernes 8:00hs a 21:00hs.\r\nSábados : 08:00 a 14:00hs\r\n";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(419, 6);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(343, 68);
            lblContacto.TabIndex = 2;
            lblContacto.Text = "Para Consultas: \r\nTeléfono (011) 1234-5678\r\nCorreo electrónico : contacto@deportivoclubsistema.com\r\n\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(263, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 78);
            panel1.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(52, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(407, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Comprobante de Inscripción";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HighlightText;
            panel3.Controls.Add(lblHorarios);
            panel3.Controls.Add(lblContacto);
            panel3.Location = new Point(15, 265);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 81);
            panel3.TabIndex = 5;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(685, 392);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(92, 39);
            btnImprimir.TabIndex = 6;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            btnImprimir.MouseEnter += btnImprimir_MouseEnter;
            btnImprimir.MouseLeave += btnImprimir_MouseLeave;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(18, 392);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(92, 39);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseEnter += btnVolver_MouseEnter;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.BackColor = SystemColors.Window;
            lblAviso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAviso.ForeColor = SystemColors.InactiveCaptionText;
            lblAviso.Location = new Point(155, 404);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(486, 15);
            lblAviso.TabIndex = 8;
            lblAviso.Text = "**Este es un comprobante de inscripción generado. Revise los detalles antes de imprimir**";
            // 
            // frmComprobanteInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAviso);
            Controls.Add(btnVolver);
            Controls.Add(btnImprimir);
            Controls.Add(panel3);
            Controls.Add(pbLogo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmComprobanteInscripcion";
            Text = "COMPROBANTE DE INSCRIPCIÓN";
            Load += frmComprobanteInscripcion_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Panel panel2;
        private Label lblHorarios;
        private Label lblContacto;
        private Panel panel1;
        private Label lblTitulo;
        private Panel panel3;
        private Label lblActividad;
        private Label lblNombre;
        private Label lblProfesor;
        private Label lblHorario;
        private Button btnImprimir;
        private Button btnVolver;
        private Label lblAviso;
        private Label lblApellido;
    }
}
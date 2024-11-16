namespace Primer_Entrega_PI
{
    partial class frmGestionPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPagos));
            btnPagar = new Button();
            btnConsultarDeuda = new Button();
            btnCerrarSesion = new Button();
            lblUsuario = new Label();
            lblFecha = new Label();
            lblTitulo = new Label();
            btnVolver = new Button();
            btnListadoVencimiento = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(359, 78);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(310, 73);
            btnPagar.TabIndex = 0;
            btnPagar.Text = "GENERAR PAGO";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnConsultarDeuda
            // 
            btnConsultarDeuda.Location = new Point(359, 323);
            btnConsultarDeuda.Name = "btnConsultarDeuda";
            btnConsultarDeuda.Size = new Size(310, 82);
            btnConsultarDeuda.TabIndex = 2;
            btnConsultarDeuda.Text = "CONSULTAR DEUDA";
            btnConsultarDeuda.UseVisualStyleBackColor = true;
            btnConsultarDeuda.Click += btnConsultarDeuda_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(669, 12);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(106, 36);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            btnCerrarSesion.MouseEnter += btnCerrarSesion_MouseEnter;
            btnCerrarSesion.MouseLeave += btnCerrarSesion_MouseLeave;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(23, 426);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "USUARIO";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(688, 426);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 15);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "FECHA";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(262, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(268, 42);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Gestión de Pagos";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(23, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(122, 36);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseEnter += btnVolver_MouseEnter;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            // 
            // btnListadoVencimiento
            // 
            btnListadoVencimiento.Location = new Point(359, 195);
            btnListadoVencimiento.Name = "btnListadoVencimiento";
            btnListadoVencimiento.Size = new Size(310, 80);
            btnListadoVencimiento.TabIndex = 8;
            btnListadoVencimiento.Text = "VENCIMIENTOS HOY";
            btnListadoVencimiento.UseVisualStyleBackColor = true;
            btnListadoVencimiento.Click += btnListadoVencimiento_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 327);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frmGestionPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnListadoVencimiento);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Controls.Add(lblFecha);
            Controls.Add(lblUsuario);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnConsultarDeuda);
            Controls.Add(btnPagar);
            Name = "frmGestionPagos";
            Text = "PAGOS";
            Load += frmPagar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPagar;
        private Button btnConsultarDeuda;
        private Button btnCerrarSesion;
        private Label lblUsuario;
        private Label lblFecha;
        private Label lblTitulo;
        private Button btnVolver;
        private Button btnListadoVencimiento;
        private PictureBox pictureBox1;
    }
}
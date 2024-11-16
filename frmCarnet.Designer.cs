namespace Primer_Entrega_PI
{
    partial class frmCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarnet));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnLimpiar = new Button();
            btnVolver = new Button();
            btnBuscar = new Button();
            lblAviso = new Label();
            btnImprimir = new Button();
            lblAsterisco2 = new Label();
            lblAsterisco = new Label();
            cboTipo = new ComboBox();
            lblTipo = new Label();
            txtAbono = new TextBox();
            txtIdSocio = new TextBox();
            lblId = new Label();
            txtApellido = new TextBox();
            lblAbono = new Label();
            txtDocumento = new TextBox();
            txtNombre = new TextBox();
            lblDocumento = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 404);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(lblAviso);
            panel1.Controls.Add(btnImprimir);
            panel1.Controls.Add(lblAsterisco2);
            panel1.Controls.Add(lblAsterisco);
            panel1.Controls.Add(cboTipo);
            panel1.Controls.Add(lblTipo);
            panel1.Controls.Add(txtAbono);
            panel1.Controls.Add(txtIdSocio);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(lblAbono);
            panel1.Controls.Add(txtDocumento);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(lblDocumento);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Enabled = false;
            btnLimpiar.Location = new Point(656, 166);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(102, 46);
            btnLimpiar.TabIndex = 35;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseEnter += btnLimpiar_MouseEnter;
            btnLimpiar.MouseLeave += btnLimpiar_MouseLeave;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(656, 14);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(102, 29);
            btnVolver.TabIndex = 34;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseEnter += btnVolver_MouseEnter;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            // 
            // btnBuscar
            // 
            btnBuscar.Enabled = false;
            btnBuscar.Location = new Point(656, 220);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(102, 43);
            btnBuscar.TabIndex = 33;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            btnBuscar.MouseEnter += btnBuscar_MouseEnter;
            btnBuscar.MouseLeave += btnBuscar_MouseLeave;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.BackColor = SystemColors.Window;
            lblAviso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAviso.ForeColor = SystemColors.GrayText;
            lblAviso.Location = new Point(152, 400);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(449, 15);
            lblAviso.TabIndex = 32;
            lblAviso.Text = "**Este es un carnet generado por el sistema. Revise los detalles antes de imprimir**";
            // 
            // btnImprimir
            // 
            btnImprimir.Enabled = false;
            btnImprimir.Location = new Point(656, 369);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(102, 46);
            btnImprimir.TabIndex = 31;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            btnImprimir.MouseEnter += btnImprimir_MouseEnter;
            btnImprimir.MouseLeave += btnImprimir_MouseLeave;
            // 
            // lblAsterisco2
            // 
            lblAsterisco2.AutoSize = true;
            lblAsterisco2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsterisco2.ForeColor = Color.Red;
            lblAsterisco2.Location = new Point(584, 287);
            lblAsterisco2.Name = "lblAsterisco2";
            lblAsterisco2.Size = new Size(17, 21);
            lblAsterisco2.TabIndex = 28;
            lblAsterisco2.Text = "*";
            // 
            // lblAsterisco
            // 
            lblAsterisco.AutoSize = true;
            lblAsterisco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsterisco.ForeColor = Color.Red;
            lblAsterisco.Location = new Point(584, 239);
            lblAsterisco.Name = "lblAsterisco";
            lblAsterisco.Size = new Size(17, 21);
            lblAsterisco.TabIndex = 27;
            lblAsterisco.Text = "*";
            // 
            // cboTipo
            // 
            cboTipo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(426, 233);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 25);
            cboTipo.TabIndex = 25;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(365, 239);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(36, 17);
            lblTipo.TabIndex = 26;
            lblTipo.Text = "Tipo";
            // 
            // txtAbono
            // 
            txtAbono.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAbono.Location = new Point(426, 337);
            txtAbono.Name = "txtAbono";
            txtAbono.Size = new Size(144, 25);
            txtAbono.TabIndex = 12;
            txtAbono.Visible = false;
            // 
            // txtIdSocio
            // 
            txtIdSocio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdSocio.Location = new Point(426, 86);
            txtIdSocio.Name = "txtIdSocio";
            txtIdSocio.Size = new Size(144, 29);
            txtIdSocio.TabIndex = 11;
            txtIdSocio.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(328, 94);
            lblId.Name = "lblId";
            lblId.Size = new Size(73, 21);
            lblId.TabIndex = 10;
            lblId.Text = "ID Socio";
            lblId.Visible = false;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(426, 189);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(144, 25);
            txtApellido.TabIndex = 9;
            txtApellido.Visible = false;
            // 
            // lblAbono
            // 
            lblAbono.AutoSize = true;
            lblAbono.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAbono.Location = new Point(361, 345);
            lblAbono.Name = "lblAbono";
            lblAbono.Size = new Size(49, 17);
            lblAbono.TabIndex = 8;
            lblAbono.Text = "Abono";
            lblAbono.Visible = false;
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumento.Location = new Point(426, 284);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(144, 25);
            txtDocumento.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(426, 143);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(144, 25);
            txtNombre.TabIndex = 6;
            txtNombre.Visible = false;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(321, 290);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(80, 17);
            lblDocumento.TabIndex = 5;
            lblDocumento.Text = "Documento";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(341, 195);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 17);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            lblApellido.Visible = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(341, 149);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            lblNombre.Visible = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(328, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(194, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "CARNET SOCIO ";
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "frmCarnet";
            Text = "CARNET";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblDocumento;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtApellido;
        private Label lblAbono;
        private TextBox txtDocumento;
        private TextBox txtNombre;
        private TextBox txtAbono;
        private TextBox txtIdSocio;
        private Label lblId;
        private Label lblAsterisco2;
        private Label lblAsterisco;
        private ComboBox cboTipo;
        private Label lblTipo;
        private Button btnImprimir;
        private Label lblAviso;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnVolver;
        private Label lblTitulo;
    }
}
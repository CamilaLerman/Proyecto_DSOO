namespace Primer_Entrega_PI
{
    partial class frmInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcion));
            lblTitulo = new Label();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            pictureBox1 = new PictureBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblTipo = new Label();
            lblDocumento = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            cboTipo = new ComboBox();
            lblAsterisco = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboSocio = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            lblAsteriscoAbono = new Label();
            lblAbono = new Label();
            cboAbono = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(371, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(321, 40);
            lblTitulo.TabIndex = 24;
            lblTitulo.Text = "Registro de Miembros";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(279, 382);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(95, 32);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            btnIngresar.MouseEnter += btnIngresar_MouseEnter;
            btnIngresar.MouseLeave += btnIngresar_MouseLeave;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(472, 382);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(95, 32);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "LIMPIAR ";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseEnter += btnLimpiar_MouseEnter;
            btnLimpiar.MouseLeave += btnLimpiar_MouseLeave;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(663, 382);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(95, 32);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseEnter += btnVolver_MouseEnter;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 402);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(307, 91);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 23;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(307, 168);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 22;
            lblApellido.Text = "Apellido";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(274, 243);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(43, 21);
            lblTipo.TabIndex = 7;
            lblTipo.Text = "Tipo";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(498, 243);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(96, 21);
            lblDocumento.TabIndex = 21;
            lblDocumento.Text = "Documento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(415, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(415, 165);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(265, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(600, 241);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(169, 23);
            txtDocumento.TabIndex = 4;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(323, 241);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 3;
            // 
            // lblAsterisco
            // 
            lblAsterisco.AutoSize = true;
            lblAsterisco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsterisco.ForeColor = Color.Red;
            lblAsterisco.Location = new Point(686, 91);
            lblAsterisco.Name = "lblAsterisco";
            lblAsterisco.Size = new Size(17, 21);
            lblAsterisco.TabIndex = 13;
            lblAsterisco.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(686, 168);
            label1.Name = "label1";
            label1.Size = new Size(17, 21);
            label1.TabIndex = 14;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(450, 243);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 15;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(775, 243);
            label3.Name = "label3";
            label3.Size = new Size(17, 21);
            label3.TabIndex = 16;
            label3.Text = "*";
            // 
            // cboSocio
            // 
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(345, 310);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(99, 23);
            cboSocio.TabIndex = 5;
            cboSocio.SelectedIndexChanged += cboSocio_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(288, 308);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 20;
            label4.Text = "Socio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(450, 312);
            label6.Name = "label6";
            label6.Size = new Size(17, 21);
            label6.TabIndex = 22;
            label6.Text = "*";
            // 
            // lblAsteriscoAbono
            // 
            lblAsteriscoAbono.AutoSize = true;
            lblAsteriscoAbono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsteriscoAbono.ForeColor = Color.Red;
            lblAsteriscoAbono.Location = new Point(752, 312);
            lblAsteriscoAbono.Name = "lblAsteriscoAbono";
            lblAsteriscoAbono.Size = new Size(17, 21);
            lblAsteriscoAbono.TabIndex = 27;
            lblAsteriscoAbono.Text = "*";
            lblAsteriscoAbono.Visible = false;
            // 
            // lblAbono
            // 
            lblAbono.AutoSize = true;
            lblAbono.Enabled = false;
            lblAbono.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAbono.Location = new Point(507, 312);
            lblAbono.Name = "lblAbono";
            lblAbono.Size = new Size(60, 21);
            lblAbono.TabIndex = 26;
            lblAbono.Text = "Abono";
            // 
            // cboAbono
            // 
            cboAbono.Enabled = false;
            cboAbono.FormattingEnabled = true;
            cboAbono.Location = new Point(582, 310);
            cboAbono.Name = "cboAbono";
            cboAbono.Size = new Size(154, 23);
            cboAbono.TabIndex = 6;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAsteriscoAbono);
            Controls.Add(lblAbono);
            Controls.Add(cboAbono);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(cboSocio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAsterisco);
            Controls.Add(cboTipo);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDocumento);
            Controls.Add(lblTipo);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(pictureBox1);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(lblTitulo);
            Name = "frmInscripcion";
            Text = "INSCRPCIÓN DE POSTULANTE";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnIngresar;
        private Button btnLimpiar;
        private Button btnVolver;
        private PictureBox pictureBox1;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTipo;
        private Label lblDocumento;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private ComboBox cboTipo;
        private Label lblAsterisco;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboSocio;
        private Label label4;
        private Label label6;
        private Label lblAsteriscoAbono;
        private Label lblAbono;
        private ComboBox cboAbono;
    }
}
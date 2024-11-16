namespace Primer_Entrega_PI
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblTitulo = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            chkMostrarPass = new CheckBox();
            btnIngresar = new Button();
            picLogo = new PictureBox();
            iconUser = new PictureBox();
            iconPass = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPass).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(378, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(190, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inicio de Sesión";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(399, 137);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(169, 23);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(399, 228);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(169, 23);
            txtPass.TabIndex = 2;
            txtPass.Text = "CONTRASEÑA";
            txtPass.TextChanged += txtPass_TextChanged;
            txtPass.Enter += txtPass_Enter;
            txtPass.KeyDown += btnIngresar_KeyDown;
            txtPass.Leave += txtPass_Leave;
            // 
            // chkMostrarPass
            // 
            chkMostrarPass.AutoSize = true;
            chkMostrarPass.Location = new Point(593, 232);
            chkMostrarPass.Name = "chkMostrarPass";
            chkMostrarPass.Size = new Size(70, 19);
            chkMostrarPass.TabIndex = 3;
            chkMostrarPass.Text = "Mostrar ";
            chkMostrarPass.UseVisualStyleBackColor = true;
            chkMostrarPass.CheckedChanged += chkMostrarPass_CheckedChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(399, 341);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(116, 37);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            btnIngresar.MouseEnter += btnIngresar_MouseEnter;
            btnIngresar.MouseLeave += btnIngresar_MouseLeave;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(25, 81);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(236, 246);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 5;
            picLogo.TabStop = false;
            // 
            // iconUser
            // 
            iconUser.Image = (Image)resources.GetObject("iconUser.Image");
            iconUser.Location = new Point(364, 137);
            iconUser.Name = "iconUser";
            iconUser.Size = new Size(29, 23);
            iconUser.SizeMode = PictureBoxSizeMode.Zoom;
            iconUser.TabIndex = 6;
            iconUser.TabStop = false;
            // 
            // iconPass
            // 
            iconPass.Image = (Image)resources.GetObject("iconPass.Image");
            iconPass.Location = new Point(364, 228);
            iconPass.Name = "iconPass";
            iconPass.Size = new Size(29, 23);
            iconPass.SizeMode = PictureBoxSizeMode.Zoom;
            iconPass.TabIndex = 7;
            iconPass.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(iconPass);
            Controls.Add(iconUser);
            Controls.Add(picLogo);
            Controls.Add(btnIngresar);
            Controls.Add(chkMostrarPass);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(lblTitulo);
            Name = "frmLogin";
            Text = "ACCESO AL SISTEMA";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private CheckBox chkMostrarPass;
        private Button btnIngresar;
        private PictureBox picLogo;
        private PictureBox iconUser;
        private PictureBox iconPass;
    }
}

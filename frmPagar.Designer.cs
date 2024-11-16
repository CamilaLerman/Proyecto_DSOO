namespace Primer_Entrega_PI
{
    partial class frmPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagar));
            lblTitulo = new Label();
            lblNPostu = new Label();
            lblTipo = new Label();
            lblDocumento = new Label();
            txtNPostu = new TextBox();
            txtDocumento = new TextBox();
            btnBuscar = new Button();
            gbxMetodoPago = new GroupBox();
            rbDebito = new RadioButton();
            rbTarjetaCredito = new RadioButton();
            rbEfectivo = new RadioButton();
            btnPagar = new Button();
            btnComprobante = new Button();
            cboTipo = new ComboBox();
            btnVolver = new Button();
            btnLimpiar = new Button();
            pbCheckPago = new PictureBox();
            gbxMetodoPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCheckPago).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(44, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(184, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Acreditar Pago";
            // 
            // lblNPostu
            // 
            lblNPostu.AutoSize = true;
            lblNPostu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNPostu.Location = new Point(44, 83);
            lblNPostu.Name = "lblNPostu";
            lblNPostu.Size = new Size(148, 17);
            lblNPostu.TabIndex = 1;
            lblNPostu.Text = "Número de Inscripción";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(44, 152);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(36, 17);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(294, 150);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(80, 17);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Documento";
            // 
            // txtNPostu
            // 
            txtNPostu.Location = new Point(209, 77);
            txtNPostu.Name = "txtNPostu";
            txtNPostu.Size = new Size(123, 23);
            txtNPostu.TabIndex = 4;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(380, 144);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(149, 23);
            txtDocumento.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(44, 208);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 31);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            btnBuscar.MouseEnter += btnBuscar_MouseEnter;
            btnBuscar.MouseLeave += btnBuscar_MouseLeave;
            // 
            // gbxMetodoPago
            // 
            gbxMetodoPago.BackColor = SystemColors.GradientInactiveCaption;
            gbxMetodoPago.Controls.Add(rbDebito);
            gbxMetodoPago.Controls.Add(rbTarjetaCredito);
            gbxMetodoPago.Controls.Add(rbEfectivo);
            gbxMetodoPago.Cursor = Cursors.Hand;
            gbxMetodoPago.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxMetodoPago.Location = new Point(44, 266);
            gbxMetodoPago.Name = "gbxMetodoPago";
            gbxMetodoPago.Size = new Size(246, 158);
            gbxMetodoPago.TabIndex = 9;
            gbxMetodoPago.TabStop = false;
            gbxMetodoPago.Text = "Método de Pago";
            // 
            // rbDebito
            // 
            rbDebito.AutoSize = true;
            rbDebito.Location = new Point(27, 110);
            rbDebito.Name = "rbDebito";
            rbDebito.Size = new Size(193, 19);
            rbDebito.TabIndex = 2;
            rbDebito.TabStop = true;
            rbDebito.Text = "Tarjeta de Débito / Transferencia";
            rbDebito.UseVisualStyleBackColor = true;
            // 
            // rbTarjetaCredito
            // 
            rbTarjetaCredito.AutoSize = true;
            rbTarjetaCredito.Location = new Point(27, 69);
            rbTarjetaCredito.Name = "rbTarjetaCredito";
            rbTarjetaCredito.Size = new Size(117, 19);
            rbTarjetaCredito.TabIndex = 1;
            rbTarjetaCredito.TabStop = true;
            rbTarjetaCredito.Text = "Tarjeta de Crédito";
            rbTarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(27, 31);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(67, 19);
            rbEfectivo.TabIndex = 0;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            btnPagar.Enabled = false;
            btnPagar.Location = new Point(352, 329);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(110, 31);
            btnPagar.TabIndex = 10;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            btnPagar.MouseEnter += btnPagar_MouseEnter;
            btnPagar.MouseLeave += btnPagar_MouseLeave;
            // 
            // btnComprobante
            // 
            btnComprobante.Enabled = false;
            btnComprobante.Location = new Point(352, 393);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(110, 31);
            btnComprobante.TabIndex = 11;
            btnComprobante.Text = "COMPROBANTE";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            btnComprobante.MouseEnter += btnComprobante_MouseEnter;
            btnComprobante.MouseLeave += btnComprobante_MouseLeave;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(104, 144);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 12;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(678, 23);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(110, 31);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseEnter += btnVolver_MouseEnter;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(380, 208);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 31);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseEnter += btnLimpiar_MouseEnter;
            btnLimpiar.MouseLeave += btnLimpiar_MouseLeave;
            // 
            // pbCheckPago
            // 
            pbCheckPago.Image = (Image)resources.GetObject("pbCheckPago.Image");
            pbCheckPago.Location = new Point(470, 333);
            pbCheckPago.Name = "pbCheckPago";
            pbCheckPago.Size = new Size(20, 24);
            pbCheckPago.SizeMode = PictureBoxSizeMode.Zoom;
            pbCheckPago.TabIndex = 15;
            pbCheckPago.TabStop = false;
            pbCheckPago.Visible = false;
            // 
            // frmPagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbCheckPago);
            Controls.Add(btnLimpiar);
            Controls.Add(btnVolver);
            Controls.Add(cboTipo);
            Controls.Add(btnComprobante);
            Controls.Add(btnPagar);
            Controls.Add(gbxMetodoPago);
            Controls.Add(btnBuscar);
            Controls.Add(txtDocumento);
            Controls.Add(txtNPostu);
            Controls.Add(lblDocumento);
            Controls.Add(lblTipo);
            Controls.Add(lblNPostu);
            Controls.Add(lblTitulo);
            Name = "frmPagar";
            Text = "GestionarAbono";
            gbxMetodoPago.ResumeLayout(false);
            gbxMetodoPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCheckPago).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNPostu;
        private Label lblTipo;
        private Label lblDocumento;
        private TextBox txtNPostu;
        private TextBox txtDocumento;
        private Button btnBuscar;
        private GroupBox gbxMetodoPago;
        private Button btnPagar;
        private Button btnComprobante;
        private ComboBox cboTipo;
        private Button btnVolver;
        private Button btnLimpiar;
        private RadioButton rbDebito;
        private RadioButton rbTarjetaCredito;
        private RadioButton rbEfectivo;
        private PictureBox pbCheckPago;
    }
}
namespace Primer_Entrega_PI
{
    partial class frmConsultarDeuda
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
            label3 = new Label();
            lblAsterisco = new Label();
            cboTipo = new ComboBox();
            lblTipo = new Label();
            txtDocumento = new TextBox();
            lblDocumento = new Label();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            btnVolver = new Button();
            lblTitulo2 = new Label();
            dtvgCuotasPendientes = new DataGridView();
            IdCuota = new DataGridViewTextBoxColumn();
            idSocio = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Fecha_Vencimiento = new DataGridViewTextBoxColumn();
            Estado_Cuota = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtvgCuotasPendientes).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(628, 62);
            label3.Name = "label3";
            label3.Size = new Size(17, 21);
            label3.TabIndex = 25;
            label3.Text = "*";
            // 
            // lblAsterisco
            // 
            lblAsterisco.AutoSize = true;
            lblAsterisco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsterisco.ForeColor = Color.Red;
            lblAsterisco.Location = new Point(234, 63);
            lblAsterisco.Name = "lblAsterisco";
            lblAsterisco.Size = new Size(17, 21);
            lblAsterisco.TabIndex = 24;
            lblAsterisco.Text = "*";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(107, 60);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 20;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(50, 66);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(36, 17);
            lblTipo.TabIndex = 23;
            lblTipo.Text = "Tipo";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(404, 61);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(218, 23);
            txtDocumento.TabIndex = 22;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(309, 67);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(80, 17);
            lblDocumento.TabIndex = 21;
            lblDocumento.Text = "Documento";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(253, 121);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(83, 33);
            btnLimpiar.TabIndex = 27;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseEnter += btnLimpiar_MouseEnter;
            btnLimpiar.MouseLeave += btnLimpiar_MouseLeave;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(52, 121);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 33);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            btnBuscar.MouseEnter += btnBuscar_MouseEnter;
            btnBuscar.MouseLeave += btnBuscar_MouseLeave;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(698, 24);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(79, 33);
            btnVolver.TabIndex = 28;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseEnter += btnVolver_MouseEnter;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo2.Location = new Point(49, 183);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(253, 25);
            lblTitulo2.TabIndex = 30;
            lblTitulo2.Text = "Cuotas Pendientes de Pago";
            // 
            // dtvgCuotasPendientes
            // 
            dtvgCuotasPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgCuotasPendientes.Columns.AddRange(new DataGridViewColumn[] { IdCuota, idSocio, Nombre, Fecha_Vencimiento, Estado_Cuota });
            dtvgCuotasPendientes.Location = new Point(49, 226);
            dtvgCuotasPendientes.Name = "dtvgCuotasPendientes";
            dtvgCuotasPendientes.Size = new Size(714, 188);
            dtvgCuotasPendientes.TabIndex = 29;
            // 
            // IdCuota
            // 
            IdCuota.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IdCuota.HeaderText = "N° Cuota";
            IdCuota.Name = "IdCuota";
            IdCuota.ToolTipText = "Se mostraran todas las cuotas a nombre del socio generadas en base a su Abono elegido. ";
            IdCuota.Width = 75;
            // 
            // idSocio
            // 
            idSocio.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            idSocio.HeaderText = "idSocio";
            idSocio.Name = "idSocio";
            idSocio.Visible = false;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Nombre.HeaderText = "Nombre y Apellido";
            Nombre.Name = "Nombre";
            Nombre.Width = 121;
            // 
            // Fecha_Vencimiento
            // 
            Fecha_Vencimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Fecha_Vencimiento.HeaderText = "Fecha de Vencimiento";
            Fecha_Vencimiento.Name = "Fecha_Vencimiento";
            Fecha_Vencimiento.ToolTipText = "Cupo calculado a partir de los inscriptos y el cupo máximo por actividad";
            Fecha_Vencimiento.Width = 135;
            // 
            // Estado_Cuota
            // 
            Estado_Cuota.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Estado_Cuota.HeaderText = "Estado de Cuota";
            Estado_Cuota.Name = "Estado_Cuota";
            Estado_Cuota.ToolTipText = "Se visualizarán solamente aquellas cuotas detalladas como \"Pendientes\".";
            Estado_Cuota.Width = 108;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 30);
            label1.TabIndex = 31;
            label1.Text = "Información del  Socio";
            // 
            // frmConsultarDeuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblTitulo2);
            Controls.Add(dtvgCuotasPendientes);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(label3);
            Controls.Add(lblAsterisco);
            Controls.Add(cboTipo);
            Controls.Add(lblTipo);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Name = "frmConsultarDeuda";
            Text = "CUOTAS PENDIENTES DE PAGO";
            ((System.ComponentModel.ISupportInitialize)dtvgCuotasPendientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label lblAsterisco;
        private ComboBox cboTipo;
        private Label lblTipo;
        private TextBox txtDocumento;
        private Label lblDocumento;
        private Button btnLimpiar;
        private Button btnBuscar;
        private Button btnVolver;
        private Label lblTitulo2;
        private DataGridView dtvgCuotasPendientes;
        private Label label1;
        private DataGridViewTextBoxColumn IdCuota;
        private DataGridViewTextBoxColumn idSocio;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Fecha_Vencimiento;
        private DataGridViewTextBoxColumn Estado_Cuota;
    }
}
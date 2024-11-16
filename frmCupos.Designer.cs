namespace Primer_Entrega_PI
{
    partial class frmCupos
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
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            lblTipo = new Label();
            cboTipo = new ComboBox();
            btnBuscar = new Button();
            dtvgActividad = new DataGridView();
            Id_Clase = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            CupoDisponible = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Dia = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            Profesor = new DataGridViewTextBoxColumn();
            lblTitulo = new Label();
            btnTraerDatos = new Button();
            btnVolver = new Button();
            btnAceptar = new Button();
            btnLimpiar = new Button();
            lblTitulo2 = new Label();
            label3 = new Label();
            lblAsterisco = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblId = new Label();
            btnComprobante = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvgActividad).BeginInit();
            SuspendLayout();
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(304, 128);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(80, 17);
            lblDocumento.TabIndex = 1;
            lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(399, 122);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(218, 23);
            txtDocumento.TabIndex = 2;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(45, 127);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(36, 17);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(102, 121);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(341, 183);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            btnBuscar.MouseEnter += btnBuscar_MouseEnter;
            btnBuscar.MouseLeave += btnBuscar_MouseLeave;
            // 
            // dtvgActividad
            // 
            dtvgActividad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgActividad.Columns.AddRange(new DataGridViewColumn[] { Id_Clase, Nombre, CupoDisponible, Precio, Dia, Horario, Profesor });
            dtvgActividad.Location = new Point(45, 275);
            dtvgActividad.Name = "dtvgActividad";
            dtvgActividad.Size = new Size(612, 126);
            dtvgActividad.TabIndex = 6;
            dtvgActividad.CellClick += dtvgActividad_CellClick;
            // 
            // Id_Clase
            // 
            Id_Clase.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Id_Clase.HeaderText = "Id_Clase";
            Id_Clase.Name = "Id_Clase";
            Id_Clase.Visible = false;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 76;
            // 
            // CupoDisponible
            // 
            CupoDisponible.HeaderText = "CupoDisponible";
            CupoDisponible.Name = "CupoDisponible";
            CupoDisponible.ToolTipText = "Cupo calculado a partir de los inscriptos y el cupo máximo por actividad";
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Visible = false;
            // 
            // Dia
            // 
            Dia.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Dia.HeaderText = "Dia";
            Dia.Name = "Dia";
            Dia.Width = 49;
            // 
            // Horario
            // 
            Horario.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Horario.HeaderText = "Horario";
            Horario.Name = "Horario";
            Horario.Width = 72;
            // 
            // Profesor
            // 
            Profesor.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Profesor.HeaderText = "Profesor";
            Profesor.Name = "Profesor";
            Profesor.Width = 76;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(42, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(236, 30);
            lblTitulo.TabIndex = 23;
            lblTitulo.Text = "Información del  Socio";
            // 
            // btnTraerDatos
            // 
            btnTraerDatos.Location = new Point(46, 183);
            btnTraerDatos.Name = "btnTraerDatos";
            btnTraerDatos.Size = new Size(200, 23);
            btnTraerDatos.TabIndex = 3;
            btnTraerDatos.Text = "VER ÚLTIMA INSCRIPCIÓN\r\n";
            btnTraerDatos.UseVisualStyleBackColor = true;
            btnTraerDatos.Click += btnTraerDatos_Click;
            btnTraerDatos.MouseEnter += btnTraerDatos_MouseEnter;
            btnTraerDatos.MouseLeave += btnTraerDatos_MouseLeave;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(704, 23);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseEnter += btnVolver_MouseEnter;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Location = new Point(680, 308);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(108, 30);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            btnAceptar.MouseEnter += btnAceptar_MouseEnter;
            btnAceptar.MouseLeave += btnAceptar_MouseLeave;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(542, 183);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseEnter += btnLimpiar_MouseEnter;
            btnLimpiar.MouseLeave += btnLimpiar_MouseLeave;
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo2.Location = new Point(45, 232);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(221, 25);
            lblTitulo2.TabIndex = 13;
            lblTitulo2.Text = "Actividades Disponibles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(623, 123);
            label3.Name = "label3";
            label3.Size = new Size(17, 21);
            label3.TabIndex = 19;
            label3.Text = "*";
            // 
            // lblAsterisco
            // 
            lblAsterisco.AutoSize = true;
            lblAsterisco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsterisco.ForeColor = Color.Red;
            lblAsterisco.Location = new Point(229, 124);
            lblAsterisco.Name = "lblAsterisco";
            lblAsterisco.Size = new Size(17, 21);
            lblAsterisco.TabIndex = 14;
            lblAsterisco.Text = "*";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Enabled = false;
            lblNombre.Location = new Point(45, 72);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Enabled = false;
            lblApellido.Location = new Point(304, 72);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 21;
            lblApellido.Text = "Apellido";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Enabled = false;
            lblId.Location = new Point(578, 72);
            lblId.Name = "lblId";
            lblId.Size = new Size(50, 15);
            lblId.TabIndex = 22;
            lblId.Text = "ID Socio";
            // 
            // btnComprobante
            // 
            btnComprobante.Enabled = false;
            btnComprobante.Location = new Point(680, 371);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(108, 30);
            btnComprobante.TabIndex = 24;
            btnComprobante.Text = "COMPROBANTE";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // frmCupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnComprobante);
            Controls.Add(lblId);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(label3);
            Controls.Add(lblAsterisco);
            Controls.Add(lblTitulo2);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Controls.Add(btnVolver);
            Controls.Add(btnTraerDatos);
            Controls.Add(lblTitulo);
            Controls.Add(dtvgActividad);
            Controls.Add(btnBuscar);
            Controls.Add(cboTipo);
            Controls.Add(lblTipo);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Name = "frmCupos";
            Text = "ASIGNAR ACTIVIDAD";
            ((System.ComponentModel.ISupportInitialize)dtvgActividad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDocumento;
        private TextBox txtDocumento;
        private Label lblTipo;
        private ComboBox cboTipo;
        private Button btnBuscar;
        private DataGridView dtvgActividad;
        private Label lblTitulo;
        private Button btnTraerDatos;
        private Button btnVolver;
        private Button btnAceptar;
        private Button btnLimpiar;
        private Label lblTitulo2;
        private Label label3;
        private Label lblAsterisco;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblId;
        private DataGridViewTextBoxColumn Id_Clase;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn CupoDisponible;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Dia;
        private DataGridViewTextBoxColumn Horario;
        private DataGridViewTextBoxColumn Profesor;
        private Button btnComprobante;
    }
}
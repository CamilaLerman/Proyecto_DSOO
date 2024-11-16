namespace Primer_Entrega_PI
{
    partial class frmListadoVencimientos
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
            lblTitulo = new Label();
            lblFecha = new Label();
            dtvgListadoVencimientos = new DataGridView();
            IdCuota = new DataGridViewTextBoxColumn();
            IdSocio = new DataGridViewTextBoxColumn();
            NombreSocio = new DataGridViewTextBoxColumn();
            Fecha_vencimiento = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvgListadoVencimientos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(293, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Listado de Cuotas Pendientes por Vencer";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(454, 21);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // dtvgListadoVencimientos
            // 
            dtvgListadoVencimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgListadoVencimientos.Columns.AddRange(new DataGridViewColumn[] { IdCuota, IdSocio, NombreSocio, Fecha_vencimiento });
            dtvgListadoVencimientos.Location = new Point(12, 52);
            dtvgListadoVencimientos.Name = "dtvgListadoVencimientos";
            dtvgListadoVencimientos.Size = new Size(776, 345);
            dtvgListadoVencimientos.TabIndex = 3;
            // 
            // IdCuota
            // 
            IdCuota.HeaderText = "Num Cuota";
            IdCuota.Name = "IdCuota";
            // 
            // IdSocio
            // 
            IdSocio.HeaderText = "ID Socio";
            IdSocio.Name = "IdSocio";
            // 
            // NombreSocio
            // 
            NombreSocio.HeaderText = "Nombre y Apellido";
            NombreSocio.Name = "NombreSocio";
            // 
            // Fecha_vencimiento
            // 
            Fecha_vencimiento.HeaderText = "Fecha de Vencimiento";
            Fecha_vencimiento.Name = "Fecha_vencimiento";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 403);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(79, 35);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseEnter += btnVolver_MouseEnter;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(701, 403);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(87, 35);
            btnImprimir.TabIndex = 5;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            btnImprimir.MouseEnter += btnImprimir_MouseEnter;
            btnImprimir.MouseLeave += btnImprimir_MouseLeave;
            // 
            // frmListadoVencimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImprimir);
            Controls.Add(btnVolver);
            Controls.Add(dtvgListadoVencimientos);
            Controls.Add(lblFecha);
            Controls.Add(lblTitulo);
            Name = "frmListadoVencimientos";
            Text = "LISTADO DE CUOTAS POR VENCER";
            Load += frmListadoVencimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dtvgListadoVencimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblFecha;
        private DataGridView dtvgListadoVencimientos;
        private DataGridViewTextBoxColumn IdCuota;
        private DataGridViewTextBoxColumn IdSocio;
        private DataGridViewTextBoxColumn NombreSocio;
        private DataGridViewTextBoxColumn Fecha_vencimiento;
        private Button btnVolver;
        private Button btnImprimir;
    }
}
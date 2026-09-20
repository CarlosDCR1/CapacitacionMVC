namespace CapaVista_prototipoumg2k26.Formas
{
    partial class FrmTipoVehiculo
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panIngresoDatos = new System.Windows.Forms.Panel();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblNumeroID = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvTipoVehiculo = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.comboI1 = new Capa_Vista_ComboI.ComboI();
            this.panIngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(33, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(736, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(775, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 32);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panIngresoDatos
            // 
            this.panIngresoDatos.Controls.Add(this.btnGrabar);
            this.panIngresoDatos.Controls.Add(this.lblNombre);
            this.panIngresoDatos.Controls.Add(this.txtDescripcion);
            this.panIngresoDatos.Controls.Add(this.lblNumeroID);
            this.panIngresoDatos.Controls.Add(this.txtNombre);
            this.panIngresoDatos.Location = new System.Drawing.Point(856, 12);
            this.panIngresoDatos.Name = "panIngresoDatos";
            this.panIngresoDatos.Size = new System.Drawing.Size(305, 530);
            this.panIngresoDatos.TabIndex = 2;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(93, 463);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(150, 44);
            this.btnGrabar.TabIndex = 8;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(27, 107);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(248, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblNumeroID
            // 
            this.lblNumeroID.AutoSize = true;
            this.lblNumeroID.Location = new System.Drawing.Point(27, 20);
            this.lblNumeroID.Name = "lblNumeroID";
            this.lblNumeroID.Size = new System.Drawing.Size(56, 16);
            this.lblNumeroID.TabIndex = 1;
            this.lblNumeroID.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(27, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // dgvTipoVehiculo
            // 
            this.dgvTipoVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoVehiculo.Location = new System.Drawing.Point(33, 67);
            this.dgvTipoVehiculo.Name = "dgvTipoVehiculo";
            this.dgvTipoVehiculo.RowHeadersWidth = 51;
            this.dgvTipoVehiculo.RowTemplate.Height = 24;
            this.dgvTipoVehiculo.Size = new System.Drawing.Size(817, 266);
            this.dgvTipoVehiculo.TabIndex = 3;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.HotPink;
            this.btnBorrar.Location = new System.Drawing.Point(744, 349);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(106, 28);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Info;
            this.btnEditar.Location = new System.Drawing.Point(634, 349);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(104, 28);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNuevo.Location = new System.Drawing.Point(524, 349);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(104, 28);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.SpringGreen;
            this.btnImprimir.Location = new System.Drawing.Point(414, 349);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(104, 28);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Aqua;
            this.btnAyuda.Location = new System.Drawing.Point(297, 349);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(111, 28);
            this.btnAyuda.TabIndex = 8;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // comboI1
            // 
            this.comboI1.Location = new System.Drawing.Point(33, 32);
            this.comboI1.Name = "comboI1";
            this.comboI1.SelectedValue = null;
            this.comboI1.Size = new System.Drawing.Size(736, 25);
            this.comboI1.TabIndex = 9;
            // 
            // FrmTipoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 554);
            this.Controls.Add(this.comboI1);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvTipoVehiculo);
            this.Controls.Add(this.panIngresoDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtSearch);
            this.Name = "FrmTipoVehiculo";
            this.Text = "01005 Mantenimiento Empleados - Prototipo v 0.5.0";
            this.Load += new System.EventHandler(this.FrmTipoVehiculo_Load);
            this.panIngresoDatos.ResumeLayout(false);
            this.panIngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panIngresoDatos;
        private System.Windows.Forms.DataGridView dgvTipoVehiculo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblNumeroID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAyuda;
        private Capa_Vista_ComboI.ComboI comboI1;
    }
}
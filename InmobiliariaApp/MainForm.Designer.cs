namespace InmobiliariaApp
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.chkDisponible = new System.Windows.Forms.CheckBox();
            this.lblFechaConstruccion = new System.Windows.Forms.Label();
            this.dtpFechaConstruccion = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarCasa = new System.Windows.Forms.Button();
            this.lstCasas = new System.Windows.Forms.ListBox();
            this.lblDireccionDetalle = new System.Windows.Forms.Label();
            this.txtDireccionDetalle = new System.Windows.Forms.TextBox();
            this.lblPrecioDetalle = new System.Windows.Forms.Label();
            this.txtPrecioDetalle = new System.Windows.Forms.TextBox();
            this.chkDisponibleDetalle = new System.Windows.Forms.CheckBox();
            this.lblFechaConstruccionDetalle = new System.Windows.Forms.Label();
            this.dtpFechaConstruccionDetalle = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 15);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(100, 12);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtDireccion.TabIndex = 1;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 41);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(100, 38);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // chkDisponible
            // 
            this.chkDisponible.AutoSize = true;
            this.chkDisponible.Location = new System.Drawing.Point(100, 64);
            this.chkDisponible.Name = "chkDisponible";
            this.chkDisponible.Size = new System.Drawing.Size(75, 17);
            this.chkDisponible.TabIndex = 4;
            this.chkDisponible.Text = "Disponible";
            this.chkDisponible.UseVisualStyleBackColor = true;
            // 
            // lblFechaConstruccion
            // 
            this.lblFechaConstruccion.AutoSize = true;
            this.lblFechaConstruccion.Location = new System.Drawing.Point(12, 90);
            this.lblFechaConstruccion.Name = "lblFechaConstruccion";
            this.lblFechaConstruccion.Size = new System.Drawing.Size(120, 13);
            this.lblFechaConstruccion.TabIndex = 5;
            this.lblFechaConstruccion.Text = "Fecha de Construcción:";
            // 
            // dtpFechaConstruccion
            // 
            this.dtpFechaConstruccion.Location = new System.Drawing.Point(126, 86);
            this.dtpFechaConstruccion.Name = "dtpFechaConstruccion";
            this.dtpFechaConstruccion.Size = new System.Drawing.Size(174, 20);
            this.dtpFechaConstruccion.TabIndex = 6;
            // 
            // btnAgregarCasa
            // 
            this.btnAgregarCasa.Location = new System.Drawing.Point(100, 112);
            this.btnAgregarCasa.Name = "btnAgregarCasa";
            this.btnAgregarCasa.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarCasa.TabIndex = 7;
            this.btnAgregarCasa.Text = "Agregar Casa";
            this.btnAgregarCasa.UseVisualStyleBackColor = true;
            this.btnAgregarCasa.Click += new System.EventHandler(this.btnAgregarCasa_Click);
            // 
            // lstCasas
            // 
            this.lstCasas.FormattingEnabled = true;
            this.lstCasas.Location = new System.Drawing.Point(330, 12);
            this.lstCasas.Name = "lstCasas";
            this.lstCasas.Size = new System.Drawing.Size(200, 238);
            this.lstCasas.TabIndex = 8;
            this.lstCasas.SelectedIndexChanged += new System.EventHandler(this.lstCasas_SelectedIndexChanged);
            // 
            // lblDireccionDetalle
            // 
            this.lblDireccionDetalle.AutoSize = true;
            this.lblDireccionDetalle.Location = new System.Drawing.Point(537, 15);
            this.lblDireccionDetalle.Name = "lblDireccionDetalle";
            this.lblDireccionDetalle.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionDetalle.TabIndex = 9;
            this.lblDireccionDetalle.Text = "Dirección:";
            // 
            // txtDireccionDetalle
            // 
            this.txtDireccionDetalle.Location = new System.Drawing.Point(600, 12);
            this.txtDireccionDetalle.Name = "txtDireccionDetalle";
            this.txtDireccionDetalle.ReadOnly = true;
            this.txtDireccionDetalle.Size = new System.Drawing.Size(200, 20);
            this.txtDireccionDetalle.TabIndex = 10;
            // 
            // lblPrecioDetalle
            // 
            this.lblPrecioDetalle.AutoSize = true;
            this.lblPrecioDetalle.Location = new System.Drawing.Point(537, 41);
            this.lblPrecioDetalle.Name = "lblPrecioDetalle";
            this.lblPrecioDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioDetalle.TabIndex = 11;
            this.lblPrecioDetalle.Text = "Precio:";
            // 
            // txtPrecioDetalle
            // 
            this.txtPrecioDetalle.Location = new System.Drawing.Point(600, 38);
            this.txtPrecioDetalle.Name = "txtPrecioDetalle";
            this.txtPrecioDetalle.ReadOnly = true;
            this.txtPrecioDetalle.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioDetalle.TabIndex = 12;
            // 
            // chkDisponibleDetalle
            // 
            this.chkDisponibleDetalle.AutoSize = true;
            this.chkDisponibleDetalle.Enabled = false;
            this.chkDisponibleDetalle.Location = new System.Drawing.Point(600, 64);
            this.chkDisponibleDetalle.Name = "chkDisponibleDetalle";
            this.chkDisponibleDetalle.Size = new System.Drawing.Size(75, 17);
            this.chkDisponibleDetalle.TabIndex = 13;
            this.chkDisponibleDetalle.Text = "Disponible";
            this.chkDisponibleDetalle.UseVisualStyleBackColor = true;
            // 
            // lblFechaConstruccionDetalle
            // 
            this.lblFechaConstruccionDetalle.AutoSize = true;
            this.lblFechaConstruccionDetalle.Location = new System.Drawing.Point(537, 90);
            this.lblFechaConstruccionDetalle.Name = "lblFechaConstruccionDetalle";
            this.lblFechaConstruccionDetalle.Size = new System.Drawing.Size(120, 13);
            this.lblFechaConstruccionDetalle.TabIndex = 14;
            this.lblFechaConstruccionDetalle.Text = "Fecha de Construcción:";
            // 
            // dtpFechaConstruccionDetalle
            // 
            this.dtpFechaConstruccionDetalle.Enabled = false;
            this.dtpFechaConstruccionDetalle.Location = new System.Drawing.Point(651, 86);
            this.dtpFechaConstruccionDetalle.Name = "dtpFechaConstruccionDetalle";
            this.dtpFechaConstruccionDetalle.Size = new System.Drawing.Size(174, 20);
            this.dtpFechaConstruccionDetalle.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 340);
            this.Controls.Add(this.dtpFechaConstruccionDetalle);
            this.Controls.Add(this.lblFechaConstruccionDetalle);
            this.Controls.Add(this.chkDisponibleDetalle);
            this.Controls.Add(this.txtPrecioDetalle);
            this.Controls.Add(this.lblPrecioDetalle);
            this.Controls.Add(this.txtDireccionDetalle);
            this.Controls.Add(this.lblDireccionDetalle);
            this.Controls.Add(this.lstCasas);
            this.Controls.Add(this.btnAgregarCasa);
            this.Controls.Add(this.dtpFechaConstruccion);
            this.Controls.Add(this.lblFechaConstruccion);
            this.Controls.Add(this.chkDisponible);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Name = "MainForm";
            this.Text = "Inmobiliaria App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.CheckBox chkDisponible;
        private System.Windows.Forms.Label lblFechaConstruccion;
        private System.Windows.Forms.DateTimePicker dtpFechaConstruccion;
        private System.Windows.Forms.Button btnAgregarCasa;
        private System.Windows.Forms.ListBox lstCasas;
        private System.Windows.Forms.Label lblDireccionDetalle;
        private System.Windows.Forms.TextBox txtDireccionDetalle;
        private System.Windows.Forms.Label lblPrecioDetalle;
        private System.Windows.Forms.TextBox txtPrecioDetalle;
        private System.Windows.Forms.CheckBox chkDisponibleDetalle;
        private System.Windows.Forms.Label lblFechaConstruccionDetalle;
        private System.Windows.Forms.DateTimePicker dtpFechaConstruccionDetalle;
    }
}

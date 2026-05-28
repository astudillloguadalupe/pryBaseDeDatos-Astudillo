namespace pryBaseDeDatos_Astudillo
{
    partial class frmBusquedaCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpDatosCliente = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblLimiteRTA = new System.Windows.Forms.Label();
            this.lblNombreRTA = new System.Windows.Forms.Label();
            this.lblDeudaRTA = new System.Windows.Forms.Label();
            this.grpDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código del Cliente";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(105, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(140, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(145, 87);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpDatosCliente
            // 
            this.grpDatosCliente.Controls.Add(this.lblDeudaRTA);
            this.grpDatosCliente.Controls.Add(this.lblNombreRTA);
            this.grpDatosCliente.Controls.Add(this.lblLimiteRTA);
            this.grpDatosCliente.Controls.Add(this.lblLimite);
            this.grpDatosCliente.Controls.Add(this.lblDeuda);
            this.grpDatosCliente.Controls.Add(this.lblNombre);
            this.grpDatosCliente.Location = new System.Drawing.Point(10, 128);
            this.grpDatosCliente.Name = "grpDatosCliente";
            this.grpDatosCliente.Size = new System.Drawing.Size(262, 145);
            this.grpDatosCliente.TabIndex = 3;
            this.grpDatosCliente.TabStop = false;
            this.grpDatosCliente.Text = "Datos del Cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(21, 67);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(42, 13);
            this.lblDeuda.TabIndex = 1;
            this.lblDeuda.Text = "Deuda:";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(21, 109);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(88, 13);
            this.lblLimite.TabIndex = 2;
            this.lblLimite.Text = "Limite de Credito:";
            // 
            // lblLimiteRTA
            // 
            this.lblLimiteRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLimiteRTA.Location = new System.Drawing.Point(135, 108);
            this.lblLimiteRTA.Name = "lblLimiteRTA";
            this.lblLimiteRTA.Size = new System.Drawing.Size(100, 23);
            this.lblLimiteRTA.TabIndex = 3;
            // 
            // lblNombreRTA
            // 
            this.lblNombreRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreRTA.Location = new System.Drawing.Point(135, 23);
            this.lblNombreRTA.Name = "lblNombreRTA";
            this.lblNombreRTA.Size = new System.Drawing.Size(100, 23);
            this.lblNombreRTA.TabIndex = 4;
            // 
            // lblDeudaRTA
            // 
            this.lblDeudaRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeudaRTA.Location = new System.Drawing.Point(135, 67);
            this.lblDeudaRTA.Name = "lblDeudaRTA";
            this.lblDeudaRTA.Size = new System.Drawing.Size(100, 23);
            this.lblDeudaRTA.TabIndex = 5;
            // 
            // frmBusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 285);
            this.Controls.Add(this.grpDatosCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBusquedaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busqueda de Cliente";
            this.grpDatosCliente.ResumeLayout(false);
            this.grpDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpDatosCliente;
        private System.Windows.Forms.Label lblDeudaRTA;
        private System.Windows.Forms.Label lblNombreRTA;
        private System.Windows.Forms.Label lblLimiteRTA;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblNombre;
    }
}
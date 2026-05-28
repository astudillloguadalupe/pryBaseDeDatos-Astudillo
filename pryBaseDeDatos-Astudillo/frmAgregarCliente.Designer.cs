namespace pryBaseDeDatos_Astudillo
{
    partial class frmAgregarCliente
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
            this.grpCargaDatos = new System.Windows.Forms.GroupBox();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.cmbAutoMovil = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.grpCargaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCargaDatos
            // 
            this.grpCargaDatos.Controls.Add(this.btnCargar);
            this.grpCargaDatos.Controls.Add(this.cmbAutoMovil);
            this.grpCargaDatos.Controls.Add(this.txtLimite);
            this.grpCargaDatos.Controls.Add(this.txtNombreApellido);
            this.grpCargaDatos.Controls.Add(this.label3);
            this.grpCargaDatos.Controls.Add(this.label2);
            this.grpCargaDatos.Controls.Add(this.lblNombreApellido);
            this.grpCargaDatos.Location = new System.Drawing.Point(12, 12);
            this.grpCargaDatos.Name = "grpCargaDatos";
            this.grpCargaDatos.Size = new System.Drawing.Size(509, 171);
            this.grpCargaDatos.TabIndex = 0;
            this.grpCargaDatos.TabStop = false;
            this.grpCargaDatos.Text = "Carga de Datos";
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Location = new System.Drawing.Point(23, 39);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(95, 13);
            this.lblNombreApellido.TabIndex = 0;
            this.lblNombreApellido.Text = "Nombre y Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Limite de Credito:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AutoMovil:";
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Location = new System.Drawing.Point(183, 32);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(155, 20);
            this.txtNombreApellido.TabIndex = 3;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(183, 79);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(155, 20);
            this.txtLimite.TabIndex = 4;
            // 
            // cmbAutoMovil
            // 
            this.cmbAutoMovil.FormattingEnabled = true;
            this.cmbAutoMovil.Location = new System.Drawing.Point(183, 121);
            this.cmbAutoMovil.Name = "cmbAutoMovil";
            this.cmbAutoMovil.Size = new System.Drawing.Size(155, 21);
            this.cmbAutoMovil.TabIndex = 5;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(405, 76);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 196);
            this.Controls.Add(this.grpCargaDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.grpCargaDatos.ResumeLayout(false);
            this.grpCargaDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCargaDatos;
        private System.Windows.Forms.ComboBox cmbAutoMovil;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Button btnCargar;
    }
}
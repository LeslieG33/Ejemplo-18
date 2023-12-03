namespace Ejemplo_18
{
    partial class frmEjemplo18
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.cmdCaptura = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdSalida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(25, 28);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(105, 13);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres capturados";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(28, 44);
            this.txtNombres.Multiline = true;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(172, 143);
            this.txtNombres.TabIndex = 1;
            // 
            // cmdCaptura
            // 
            this.cmdCaptura.Location = new System.Drawing.Point(228, 42);
            this.cmdCaptura.Name = "cmdCaptura";
            this.cmdCaptura.Size = new System.Drawing.Size(75, 42);
            this.cmdCaptura.TabIndex = 2;
            this.cmdCaptura.Text = "&Inicio Captura";
            this.cmdCaptura.UseVisualStyleBackColor = true;
            this.cmdCaptura.Click += new System.EventHandler(this.cmdCaptura_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(228, 90);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(75, 42);
            this.cmdLimpiar.TabIndex = 3;
            this.cmdLimpiar.Text = "&Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdSalida
            // 
            this.cmdSalida.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdSalida.Location = new System.Drawing.Point(228, 138);
            this.cmdSalida.Name = "cmdSalida";
            this.cmdSalida.Size = new System.Drawing.Size(75, 42);
            this.cmdSalida.TabIndex = 4;
            this.cmdSalida.Text = "&Salida";
            this.cmdSalida.UseVisualStyleBackColor = true;
            this.cmdSalida.Click += new System.EventHandler(this.cmdSalida_Click);
            // 
            // frmEjemplo18
            // 
            this.AcceptButton = this.cmdCaptura;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdSalida;
            this.ClientSize = new System.Drawing.Size(337, 223);
            this.Controls.Add(this.cmdSalida);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdCaptura);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombres);
            this.Name = "frmEjemplo18";
            this.Text = "Captura de 5 nombres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Button cmdCaptura;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdSalida;
    }
}


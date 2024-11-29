namespace ejercicioTelegrama
{
    partial class Form1
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
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.chkUrgente = new System.Windows.Forms.CheckBox();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.lblCoste = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Location = new System.Drawing.Point(489, 321);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(235, 63);
            this.btnCalcularPrecio.TabIndex = 11;
            this.btnCalcularPrecio.Text = "Calcular precio";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(144, 364);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 26);
            this.txtPrecio.TabIndex = 10;
            // 
            // chkUrgente
            // 
            this.chkUrgente.AutoSize = true;
            this.chkUrgente.Location = new System.Drawing.Point(80, 307);
            this.chkUrgente.Name = "chkUrgente";
            this.chkUrgente.Size = new System.Drawing.Size(106, 24);
            this.chkUrgente.TabIndex = 9;
            this.chkUrgente.Text = "Urgente ?";
            this.chkUrgente.UseVisualStyleBackColor = true;
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(80, 84);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(644, 202);
            this.txtTelegrama.TabIndex = 8;
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoste.Location = new System.Drawing.Point(76, 364);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(61, 20);
            this.lblCoste.TabIndex = 7;
            this.lblCoste.Text = "Coste:";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(76, 60);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(53, 20);
            this.lblTexto.TabIndex = 6;
            this.lblTexto.Text = "Texto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.chkUrgente);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.lblCoste);
            this.Controls.Add(this.lblTexto);
            this.Name = "Form1";
            this.Text = "Practica Git";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.CheckBox chkUrgente;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.Label lblTexto;
    }
}


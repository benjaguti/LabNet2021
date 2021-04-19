namespace EjercicioMethodsExtException
{
    partial class EjercicioExceptionMethodExt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.txtCociente = new System.Windows.Forms.TextBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDividir);
            this.groupBox1.Controls.Add(this.txtCociente);
            this.groupBox1.Controls.Add(this.txtDivisor);
            this.groupBox1.Controls.Add(this.txtDividendo);
            this.groupBox1.Location = new System.Drawing.Point(25, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "División";
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(95, 30);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 20);
            this.txtDividendo.TabIndex = 0;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(95, 68);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 20);
            this.txtDivisor.TabIndex = 1;
            // 
            // txtCociente
            // 
            this.txtCociente.Location = new System.Drawing.Point(22, 141);
            this.txtCociente.Name = "txtCociente";
            this.txtCociente.Size = new System.Drawing.Size(216, 20);
            this.txtCociente.TabIndex = 2;
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(95, 103);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 3;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // EjercicioExceptionMethodExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "EjercicioExceptionMethodExt";
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.TextBox txtCociente;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.TextBox txtDividendo;
    }
}


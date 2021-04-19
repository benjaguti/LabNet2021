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
            this.btnDividir = new System.Windows.Forms.Button();
            this.txtCociente = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDiv = new System.Windows.Forms.Button();
            this.txtValorDiv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSolucion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFormatoExc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDividir);
            this.groupBox1.Controls.Add(this.txtCociente);
            this.groupBox1.Controls.Add(this.txtDivisor);
            this.groupBox1.Controls.Add(this.txtDividendo);
            this.groupBox1.Location = new System.Drawing.Point(44, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "División 2 variables";
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
            // txtCociente
            // 
            this.txtCociente.Location = new System.Drawing.Point(95, 141);
            this.txtCociente.Name = "txtCociente";
            this.txtCociente.Size = new System.Drawing.Size(100, 20);
            this.txtCociente.TabIndex = 2;
            this.txtCociente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(95, 68);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 20);
            this.txtDivisor.TabIndex = 1;
            this.txtDivisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(95, 30);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 20);
            this.txtDividendo.TabIndex = 0;
            this.txtDividendo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSolucion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnDiv);
            this.groupBox2.Controls.Add(this.txtValorDiv);
            this.groupBox2.Location = new System.Drawing.Point(44, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "División 1 variable";
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(101, 56);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "Dividir";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // txtValorDiv
            // 
            this.txtValorDiv.Location = new System.Drawing.Point(101, 30);
            this.txtValorDiv.Name = "txtValorDiv";
            this.txtValorDiv.Size = new System.Drawing.Size(100, 20);
            this.txtValorDiv.TabIndex = 0;
            this.txtValorDiv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dividendo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Divisor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Solución:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dividendo:";
            // 
            // txtSolucion
            // 
            this.txtSolucion.Location = new System.Drawing.Point(101, 85);
            this.txtSolucion.Name = "txtSolucion";
            this.txtSolucion.Size = new System.Drawing.Size(100, 20);
            this.txtSolucion.TabIndex = 6;
            this.txtSolucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Solución:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnFormatoExc);
            this.groupBox3.Controls.Add(this.txtLetra);
            this.groupBox3.Location = new System.Drawing.Point(456, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 121);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ejercicio 3";
            // 
            // btnFormatoExc
            // 
            this.btnFormatoExc.Location = new System.Drawing.Point(101, 67);
            this.btnFormatoExc.Name = "btnFormatoExc";
            this.btnFormatoExc.Size = new System.Drawing.Size(100, 37);
            this.btnFormatoExc.TabIndex = 3;
            this.btnFormatoExc.Text = "Generar Excepcion";
            this.btnFormatoExc.UseVisualStyleBackColor = true;
            this.btnFormatoExc.Click += new System.EventHandler(this.btnFormatoExc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ingrese letra";
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(101, 30);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(100, 20);
            this.txtLetra.TabIndex = 0;
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EjercicioExceptionMethodExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EjercicioExceptionMethodExt";
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.TextBox txtCociente;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox txtValorDiv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSolucion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFormatoExc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLetra;
    }
}


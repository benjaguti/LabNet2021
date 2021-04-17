namespace EjercicioPoo
{
    partial class FrmVisualizaciónTrans
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
            this.btnMostraGeneral = new System.Windows.Forms.Button();
            this.dgvTransporte = new System.Windows.Forms.DataGridView();
            this.btnAviones = new System.Windows.Forms.Button();
            this.btnMostrarAutos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostraGeneral
            // 
            this.btnMostraGeneral.Location = new System.Drawing.Point(113, 35);
            this.btnMostraGeneral.Name = "btnMostraGeneral";
            this.btnMostraGeneral.Size = new System.Drawing.Size(75, 46);
            this.btnMostraGeneral.TabIndex = 0;
            this.btnMostraGeneral.Text = "Mostrar Transportes";
            this.btnMostraGeneral.UseVisualStyleBackColor = true;
            this.btnMostraGeneral.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvTransporte
            // 
            this.dgvTransporte.AllowUserToAddRows = false;
            this.dgvTransporte.AllowUserToDeleteRows = false;
            this.dgvTransporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransporte.Location = new System.Drawing.Point(294, 26);
            this.dgvTransporte.Name = "dgvTransporte";
            this.dgvTransporte.ReadOnly = true;
            this.dgvTransporte.Size = new System.Drawing.Size(334, 310);
            this.dgvTransporte.TabIndex = 1;
            // 
            // btnAviones
            // 
            this.btnAviones.Location = new System.Drawing.Point(113, 110);
            this.btnAviones.Name = "btnAviones";
            this.btnAviones.Size = new System.Drawing.Size(75, 46);
            this.btnAviones.TabIndex = 2;
            this.btnAviones.Text = "Mostrar Aviones";
            this.btnAviones.UseVisualStyleBackColor = true;
            this.btnAviones.Click += new System.EventHandler(this.btnAviones_Click);
            // 
            // btnMostrarAutos
            // 
            this.btnMostrarAutos.Location = new System.Drawing.Point(113, 183);
            this.btnMostrarAutos.Name = "btnMostrarAutos";
            this.btnMostrarAutos.Size = new System.Drawing.Size(75, 46);
            this.btnMostrarAutos.TabIndex = 3;
            this.btnMostrarAutos.Text = "Mostrar Autos";
            this.btnMostrarAutos.UseVisualStyleBackColor = true;
            this.btnMostrarAutos.Click += new System.EventHandler(this.btnMostrarAutos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::EjercicioPoo.Properties.Resources.avion_auto_810x455;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmVisualizaciónTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 358);
            this.Controls.Add(this.btnMostrarAutos);
            this.Controls.Add(this.btnAviones);
            this.Controls.Add(this.dgvTransporte);
            this.Controls.Add(this.btnMostraGeneral);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmVisualizaciónTrans";
            this.Text = "Visualización de pasajeros por transporte";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostraGeneral;
        private System.Windows.Forms.DataGridView dgvTransporte;
        private System.Windows.Forms.Button btnAviones;
        private System.Windows.Forms.Button btnMostrarAutos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace Numeros_aleatorios_algoritmos
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btn_cua_min = new System.Windows.Forms.Button();
            this.btn_prod_min = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_mixto_lineal = new System.Windows.Forms.Button();
            this.btn_congru_multi = new System.Windows.Forms.Button();
            this.btn_aditivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cua_min
            // 
            this.btn_cua_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cua_min.Location = new System.Drawing.Point(333, 48);
            this.btn_cua_min.Name = "btn_cua_min";
            this.btn_cua_min.Size = new System.Drawing.Size(113, 46);
            this.btn_cua_min.TabIndex = 0;
            this.btn_cua_min.Text = "Cuadrados Medios";
            this.btn_cua_min.UseVisualStyleBackColor = true;
            this.btn_cua_min.Click += new System.EventHandler(this.btn_cua_min_Click);
            // 
            // btn_prod_min
            // 
            this.btn_prod_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod_min.Location = new System.Drawing.Point(333, 99);
            this.btn_prod_min.Name = "btn_prod_min";
            this.btn_prod_min.Size = new System.Drawing.Size(113, 46);
            this.btn_prod_min.TabIndex = 1;
            this.btn_prod_min.Text = "Productos Medios";
            this.btn_prod_min.UseVisualStyleBackColor = true;
            this.btn_prod_min.Click += new System.EventHandler(this.btn_prod_min_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "NÚMEROS ALEATORIOS Y PRUEBAS";
            // 
            // btn_mixto_lineal
            // 
            this.btn_mixto_lineal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mixto_lineal.Location = new System.Drawing.Point(333, 202);
            this.btn_mixto_lineal.Name = "btn_mixto_lineal";
            this.btn_mixto_lineal.Size = new System.Drawing.Size(113, 46);
            this.btn_mixto_lineal.TabIndex = 4;
            this.btn_mixto_lineal.Text = "Mixto o Lineal";
            this.btn_mixto_lineal.UseVisualStyleBackColor = true;
            this.btn_mixto_lineal.Click += new System.EventHandler(this.btn_mixto_lineal_Click);
            // 
            // btn_congru_multi
            // 
            this.btn_congru_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_congru_multi.Location = new System.Drawing.Point(333, 150);
            this.btn_congru_multi.Name = "btn_congru_multi";
            this.btn_congru_multi.Size = new System.Drawing.Size(113, 46);
            this.btn_congru_multi.TabIndex = 3;
            this.btn_congru_multi.Text = "Congruencial Multiplicativo";
            this.btn_congru_multi.UseVisualStyleBackColor = true;
            this.btn_congru_multi.Click += new System.EventHandler(this.btn_congru_multi_Click);
            // 
            // btn_aditivo
            // 
            this.btn_aditivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aditivo.Location = new System.Drawing.Point(333, 254);
            this.btn_aditivo.Name = "btn_aditivo";
            this.btn_aditivo.Size = new System.Drawing.Size(113, 46);
            this.btn_aditivo.TabIndex = 5;
            this.btn_aditivo.Text = "Aditivo";
            this.btn_aditivo.UseVisualStyleBackColor = true;
            this.btn_aditivo.Click += new System.EventHandler(this.btn_aditivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sam CA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Genera números y aplica los diferentes tipos de pruebas";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 327);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_aditivo);
            this.Controls.Add(this.btn_mixto_lineal);
            this.Controls.Add(this.btn_congru_multi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_prod_min);
            this.Controls.Add(this.btn_cua_min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guia Laboratorio 2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cua_min;
        private System.Windows.Forms.Button btn_prod_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mixto_lineal;
        private System.Windows.Forms.Button btn_congru_multi;
        private System.Windows.Forms.Button btn_aditivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}


namespace Numeros_aleatorios_algoritmos
{
    partial class mixto_lineal
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
            this.btn_generar = new System.Windows.Forms.Button();
            this.tabla_mixto = new System.Windows.Forms.DataGridView();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_max_aleatorio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_m = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_g = new System.Windows.Forms.TextBox();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ciclo_vida = new System.Windows.Forms.TextBox();
            this.txt_semilla = new System.Windows.Forms.TextBox();
            this.label_a = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_c = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_prueba_independencia = new System.Windows.Forms.Button();
            this.btn_uniformidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_mixto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(404, 23);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(87, 40);
            this.btn_generar.TabIndex = 5;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // tabla_mixto
            // 
            this.tabla_mixto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_mixto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n,
            this.ecuacion,
            this.Xi,
            this.ri});
            this.tabla_mixto.Location = new System.Drawing.Point(36, 88);
            this.tabla_mixto.Name = "tabla_mixto";
            this.tabla_mixto.ReadOnly = true;
            this.tabla_mixto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_mixto.Size = new System.Drawing.Size(555, 208);
            this.tabla_mixto.TabIndex = 6;
            // 
            // n
            // 
            this.n.HeaderText = "n";
            this.n.Name = "n";
            this.n.ReadOnly = true;
            // 
            // ecuacion
            // 
            this.ecuacion.HeaderText = "Ecuacion";
            this.ecuacion.Name = "ecuacion";
            this.ecuacion.ReadOnly = true;
            // 
            // Xi
            // 
            this.Xi.HeaderText = "Xi";
            this.Xi.Name = "Xi";
            this.Xi.ReadOnly = true;
            // 
            // ri
            // 
            this.ri.HeaderText = "Ri";
            this.ri.Name = "ri";
            this.ri.ReadOnly = true;
            // 
            // cant_max_aleatorio
            // 
            this.cant_max_aleatorio.AutoSize = true;
            this.cant_max_aleatorio.Location = new System.Drawing.Point(317, 61);
            this.cant_max_aleatorio.Name = "cant_max_aleatorio";
            this.cant_max_aleatorio.Size = new System.Drawing.Size(13, 13);
            this.cant_max_aleatorio.TabIndex = 37;
            this.cant_max_aleatorio.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Cantidad Max Aleatorios:";
            // 
            // label_m
            // 
            this.label_m.AutoSize = true;
            this.label_m.Location = new System.Drawing.Point(211, 39);
            this.label_m.Name = "label_m";
            this.label_m.Size = new System.Drawing.Size(13, 13);
            this.label_m.TabIndex = 35;
            this.label_m.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "m:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "g";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "K";
            // 
            // txt_g
            // 
            this.txt_g.Location = new System.Drawing.Point(211, 9);
            this.txt_g.Name = "txt_g";
            this.txt_g.Size = new System.Drawing.Size(100, 20);
            this.txt_g.TabIndex = 4;
            this.txt_g.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_g_KeyPress);
            // 
            // txt_k
            // 
            this.txt_k.Location = new System.Drawing.Point(76, 61);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(100, 20);
            this.txt_k.TabIndex = 3;
            this.txt_k.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_k_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "X0";
            // 
            // txt_ciclo_vida
            // 
            this.txt_ciclo_vida.Location = new System.Drawing.Point(75, 35);
            this.txt_ciclo_vida.Name = "txt_ciclo_vida";
            this.txt_ciclo_vida.Size = new System.Drawing.Size(100, 20);
            this.txt_ciclo_vida.TabIndex = 2;
            this.txt_ciclo_vida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ciclo_vida_KeyPress);
            // 
            // txt_semilla
            // 
            this.txt_semilla.Location = new System.Drawing.Point(75, 9);
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(100, 20);
            this.txt_semilla.TabIndex = 1;
            this.txt_semilla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_semilla_KeyPress);
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(286, 38);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(13, 13);
            this.label_a.TabIndex = 39;
            this.label_a.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "a:";
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Location = new System.Drawing.Point(365, 39);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(13, 13);
            this.label_c.TabIndex = 41;
            this.label_c.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "c:";
            // 
            // btn_prueba_independencia
            // 
            this.btn_prueba_independencia.Location = new System.Drawing.Point(497, 43);
            this.btn_prueba_independencia.Name = "btn_prueba_independencia";
            this.btn_prueba_independencia.Size = new System.Drawing.Size(94, 39);
            this.btn_prueba_independencia.TabIndex = 43;
            this.btn_prueba_independencia.Text = "Pruebas Independencia";
            this.btn_prueba_independencia.UseVisualStyleBackColor = true;
            this.btn_prueba_independencia.Click += new System.EventHandler(this.btn_prueba_independencia_Click);
            // 
            // btn_uniformidad
            // 
            this.btn_uniformidad.Location = new System.Drawing.Point(497, 2);
            this.btn_uniformidad.Name = "btn_uniformidad";
            this.btn_uniformidad.Size = new System.Drawing.Size(94, 39);
            this.btn_uniformidad.TabIndex = 42;
            this.btn_uniformidad.Text = "Pruebas uniformidad";
            this.btn_uniformidad.UseVisualStyleBackColor = true;
            this.btn_uniformidad.Click += new System.EventHandler(this.btn_uniformidad_Click);
            // 
            // mixto_lineal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 308);
            this.Controls.Add(this.btn_prueba_independencia);
            this.Controls.Add(this.btn_uniformidad);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cant_max_aleatorio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_m);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_g);
            this.Controls.Add(this.txt_k);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ciclo_vida);
            this.Controls.Add(this.txt_semilla);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.tabla_mixto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mixto_lineal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mixto_lineal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mixto_lineal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_mixto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.DataGridView tabla_mixto;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecuacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ri;
        private System.Windows.Forms.Label cant_max_aleatorio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_m;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_g;
        private System.Windows.Forms.TextBox txt_k;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ciclo_vida;
        private System.Windows.Forms.TextBox txt_semilla;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_prueba_independencia;
        private System.Windows.Forms.Button btn_uniformidad;
    }
}
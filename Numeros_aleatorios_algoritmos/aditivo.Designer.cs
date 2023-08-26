namespace Numeros_aleatorios_algoritmos
{
    partial class aditivo
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
            this.tabla_aditivo = new System.Windows.Forms.DataGridView();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ec_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_m = new System.Windows.Forms.TextBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_prueba_independencia = new System.Windows.Forms.Button();
            this.btn_uniformidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_aditivo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabla_aditivo
            // 
            this.tabla_aditivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_aditivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n,
            this.ecuacion,
            this.ec_valor,
            this.Ri});
            this.tabla_aditivo.Location = new System.Drawing.Point(176, 27);
            this.tabla_aditivo.Name = "tabla_aditivo";
            this.tabla_aditivo.ReadOnly = true;
            this.tabla_aditivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_aditivo.Size = new System.Drawing.Size(473, 216);
            this.tabla_aditivo.TabIndex = 29;
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
            // ec_valor
            // 
            this.ec_valor.HeaderText = "Ec_valor";
            this.ec_valor.Name = "ec_valor";
            this.ec_valor.ReadOnly = true;
            // 
            // Ri
            // 
            this.Ri.HeaderText = "Ri";
            this.Ri.Name = "Ri";
            this.Ri.ReadOnly = true;
            // 
            // txt_m
            // 
            this.txt_m.Location = new System.Drawing.Point(60, 27);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(100, 20);
            this.txt_m.TabIndex = 8;
            this.txt_m.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_m_KeyPress);
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(176, 256);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 35);
            this.btn_generar.TabIndex = 28;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "m";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(16, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 213);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "X6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "X5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "X4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "X3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "X2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "X1";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(44, 184);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 28;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(44, 151);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 27;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(44, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 26;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(44, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 25;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 24;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_prueba_independencia
            // 
            this.btn_prueba_independencia.Location = new System.Drawing.Point(369, 254);
            this.btn_prueba_independencia.Name = "btn_prueba_independencia";
            this.btn_prueba_independencia.Size = new System.Drawing.Size(94, 39);
            this.btn_prueba_independencia.TabIndex = 31;
            this.btn_prueba_independencia.Text = "Pruebas Independencia";
            this.btn_prueba_independencia.UseVisualStyleBackColor = true;
            this.btn_prueba_independencia.Click += new System.EventHandler(this.btn_prueba_independencia_Click);
            // 
            // btn_uniformidad
            // 
            this.btn_uniformidad.Location = new System.Drawing.Point(269, 254);
            this.btn_uniformidad.Name = "btn_uniformidad";
            this.btn_uniformidad.Size = new System.Drawing.Size(94, 39);
            this.btn_uniformidad.TabIndex = 30;
            this.btn_uniformidad.Text = "Pruebas uniformidad";
            this.btn_uniformidad.UseVisualStyleBackColor = true;
            this.btn_uniformidad.Click += new System.EventHandler(this.btn_uniformidad_Click);
            // 
            // aditivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 308);
            this.Controls.Add(this.btn_prueba_independencia);
            this.Controls.Add(this.btn_uniformidad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.txt_m);
            this.Controls.Add(this.tabla_aditivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "aditivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aditivo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.aditivo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_aditivo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_aditivo;
        private System.Windows.Forms.TextBox txt_m;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecuacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ec_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_prueba_independencia;
        private System.Windows.Forms.Button btn_uniformidad;
    }
}
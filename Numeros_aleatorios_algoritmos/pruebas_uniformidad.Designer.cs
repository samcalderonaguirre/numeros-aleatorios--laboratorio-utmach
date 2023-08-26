namespace Numeros_aleatorios_algoritmos
{
    partial class pruebas_uniformidad
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
            this.dataGridView_aleatorios = new System.Windows.Forms.DataGridView();
            this.ri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_nombre_algoritmo = new System.Windows.Forms.Label();
            this.radioButton_chi_cuadrado = new System.Windows.Forms.RadioButton();
            this.radioButton_kolmogorov = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_alfa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_cantidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_alfa_error = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_intervalos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_maxdn = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btn_aplicar_prueba = new System.Windows.Forms.Button();
            this.dataGridView_prueba = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.criterio_chi_cuadrado = new System.Windows.Forms.Label();
            this.label_criterio_kolmogorov = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_respuesta = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_valor_tabla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_xo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aleatorios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prueba)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_aleatorios
            // 
            this.dataGridView_aleatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_aleatorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ri});
            this.dataGridView_aleatorios.Location = new System.Drawing.Point(12, 29);
            this.dataGridView_aleatorios.Name = "dataGridView_aleatorios";
            this.dataGridView_aleatorios.Size = new System.Drawing.Size(143, 317);
            this.dataGridView_aleatorios.TabIndex = 0;
            // 
            // ri
            // 
            this.ri.HeaderText = "Ri";
            this.ri.Name = "ri";
            // 
            // label_nombre_algoritmo
            // 
            this.label_nombre_algoritmo.AutoSize = true;
            this.label_nombre_algoritmo.Location = new System.Drawing.Point(12, 9);
            this.label_nombre_algoritmo.Name = "label_nombre_algoritmo";
            this.label_nombre_algoritmo.Size = new System.Drawing.Size(13, 13);
            this.label_nombre_algoritmo.TabIndex = 1;
            this.label_nombre_algoritmo.Text = "--";
            // 
            // radioButton_chi_cuadrado
            // 
            this.radioButton_chi_cuadrado.AutoSize = true;
            this.radioButton_chi_cuadrado.Location = new System.Drawing.Point(15, 23);
            this.radioButton_chi_cuadrado.Name = "radioButton_chi_cuadrado";
            this.radioButton_chi_cuadrado.Size = new System.Drawing.Size(89, 17);
            this.radioButton_chi_cuadrado.TabIndex = 2;
            this.radioButton_chi_cuadrado.TabStop = true;
            this.radioButton_chi_cuadrado.Text = "Chi Cuadrado";
            this.radioButton_chi_cuadrado.UseVisualStyleBackColor = true;
            this.radioButton_chi_cuadrado.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton_kolmogorov
            // 
            this.radioButton_kolmogorov.AutoSize = true;
            this.radioButton_kolmogorov.Location = new System.Drawing.Point(15, 51);
            this.radioButton_kolmogorov.Name = "radioButton_kolmogorov";
            this.radioButton_kolmogorov.Size = new System.Drawing.Size(81, 17);
            this.radioButton_kolmogorov.TabIndex = 3;
            this.radioButton_kolmogorov.TabStop = true;
            this.radioButton_kolmogorov.Text = "Kolmogorov";
            this.radioButton_kolmogorov.UseVisualStyleBackColor = true;
            this.radioButton_kolmogorov.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_kolmogorov);
            this.groupBox1.Controls.Add(this.radioButton_chi_cuadrado);
            this.groupBox1.Location = new System.Drawing.Point(161, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Prueba";
            // 
            // txt_alfa
            // 
            this.txt_alfa.Location = new System.Drawing.Point(374, 42);
            this.txt_alfa.Name = "txt_alfa";
            this.txt_alfa.Size = new System.Drawing.Size(46, 20);
            this.txt_alfa.TabIndex = 5;
            this.txt_alfa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_alfa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_alfa_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "α";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "n";
            // 
            // label_cantidad
            // 
            this.label_cantidad.AutoSize = true;
            this.label_cantidad.Location = new System.Drawing.Point(371, 19);
            this.label_cantidad.Name = "label_cantidad";
            this.label_cantidad.Size = new System.Drawing.Size(92, 13);
            this.label_cantidad.TabIndex = 8;
            this.label_cantidad.Text = "Cantidad numeros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Error";
            // 
            // label_alfa_error
            // 
            this.label_alfa_error.AutoSize = true;
            this.label_alfa_error.Location = new System.Drawing.Point(371, 74);
            this.label_alfa_error.Name = "label_alfa_error";
            this.label_alfa_error.Size = new System.Drawing.Size(29, 13);
            this.label_alfa_error.TabIndex = 10;
            this.label_alfa_error.Text = "1 - α";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "intervalos";
            // 
            // txt_intervalos
            // 
            this.txt_intervalos.Enabled = false;
            this.txt_intervalos.Location = new System.Drawing.Point(374, 97);
            this.txt_intervalos.Name = "txt_intervalos";
            this.txt_intervalos.Size = new System.Drawing.Size(100, 20);
            this.txt_intervalos.TabIndex = 12;
            this.txt_intervalos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_intervalos_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max Dn";
            // 
            // label_maxdn
            // 
            this.label_maxdn.AutoSize = true;
            this.label_maxdn.Location = new System.Drawing.Point(598, 18);
            this.label_maxdn.Name = "label_maxdn";
            this.label_maxdn.Size = new System.Drawing.Size(13, 13);
            this.label_maxdn.TabIndex = 15;
            this.label_maxdn.Text = "--";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(531, 46);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 13);
            this.label.TabIndex = 16;
            this.label.Text = "D α ;n ó (X(α;m-1))^2";
            // 
            // btn_aplicar_prueba
            // 
            this.btn_aplicar_prueba.Location = new System.Drawing.Point(671, 142);
            this.btn_aplicar_prueba.Name = "btn_aplicar_prueba";
            this.btn_aplicar_prueba.Size = new System.Drawing.Size(124, 50);
            this.btn_aplicar_prueba.TabIndex = 18;
            this.btn_aplicar_prueba.Text = "Aplicar Prueba";
            this.btn_aplicar_prueba.UseVisualStyleBackColor = true;
            this.btn_aplicar_prueba.Click += new System.EventHandler(this.btn_aplicar_prueba_Click);
            // 
            // dataGridView_prueba
            // 
            this.dataGridView_prueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_prueba.Location = new System.Drawing.Point(188, 154);
            this.dataGridView_prueba.Name = "dataGridView_prueba";
            this.dataGridView_prueba.Size = new System.Drawing.Size(472, 192);
            this.dataGridView_prueba.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(531, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Criterio - Chi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(598, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Xo^2 <  (X(α;m-1))^2";
            // 
            // criterio_chi_cuadrado
            // 
            this.criterio_chi_cuadrado.AutoSize = true;
            this.criterio_chi_cuadrado.Location = new System.Drawing.Point(709, 74);
            this.criterio_chi_cuadrado.Name = "criterio_chi_cuadrado";
            this.criterio_chi_cuadrado.Size = new System.Drawing.Size(13, 13);
            this.criterio_chi_cuadrado.TabIndex = 24;
            this.criterio_chi_cuadrado.Text = "--";
            // 
            // label_criterio_kolmogorov
            // 
            this.label_criterio_kolmogorov.AutoSize = true;
            this.label_criterio_kolmogorov.Location = new System.Drawing.Point(668, 107);
            this.label_criterio_kolmogorov.Name = "label_criterio_kolmogorov";
            this.label_criterio_kolmogorov.Size = new System.Drawing.Size(13, 13);
            this.label_criterio_kolmogorov.TabIndex = 26;
            this.label_criterio_kolmogorov.Text = "--";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(598, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Dn < Dα;n";
            // 
            // label_respuesta
            // 
            this.label_respuesta.AutoSize = true;
            this.label_respuesta.Location = new System.Drawing.Point(189, 353);
            this.label_respuesta.Name = "label_respuesta";
            this.label_respuesta.Size = new System.Drawing.Size(13, 13);
            this.label_respuesta.TabIndex = 27;
            this.label_respuesta.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(531, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Criterio - KS:";
            // 
            // txt_valor_tabla
            // 
            this.txt_valor_tabla.Location = new System.Drawing.Point(644, 42);
            this.txt_valor_tabla.Name = "txt_valor_tabla";
            this.txt_valor_tabla.Size = new System.Drawing.Size(46, 20);
            this.txt_valor_tabla.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Xo^2";
            // 
            // label_xo2
            // 
            this.label_xo2.AutoSize = true;
            this.label_xo2.Location = new System.Drawing.Point(371, 128);
            this.label_xo2.Name = "label_xo2";
            this.label_xo2.Size = new System.Drawing.Size(13, 13);
            this.label_xo2.TabIndex = 31;
            this.label_xo2.Text = "--";
            // 
            // pruebas_uniformidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 372);
            this.Controls.Add(this.label_xo2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_valor_tabla);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_respuesta);
            this.Controls.Add(this.label_criterio_kolmogorov);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.criterio_chi_cuadrado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView_prueba);
            this.Controls.Add(this.btn_aplicar_prueba);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label_maxdn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_intervalos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_alfa_error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_alfa);
            this.Controls.Add(this.label_nombre_algoritmo);
            this.Controls.Add(this.dataGridView_aleatorios);
            this.Name = "pruebas_uniformidad";
            this.Text = "pruebas_uniformidad";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aleatorios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_nombre_algoritmo;
        private System.Windows.Forms.RadioButton radioButton_chi_cuadrado;
        private System.Windows.Forms.RadioButton radioButton_kolmogorov;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_alfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_intervalos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_maxdn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_aplicar_prueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn ri;
        public System.Windows.Forms.DataGridView dataGridView_aleatorios;
        public System.Windows.Forms.DataGridView dataGridView_prueba;
        public System.Windows.Forms.Label label_cantidad;
        private System.Windows.Forms.Label label_alfa_error;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label criterio_chi_cuadrado;
        private System.Windows.Forms.Label label_criterio_kolmogorov;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_respuesta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_valor_tabla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_xo2;
    }
}
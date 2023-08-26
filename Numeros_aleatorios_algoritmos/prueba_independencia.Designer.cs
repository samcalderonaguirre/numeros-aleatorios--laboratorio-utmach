namespace Numeros_aleatorios_algoritmos
{
    partial class prueba_independencia
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
            this.dataGridView_prueba = new System.Windows.Forms.DataGridView();
            this.s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Corrida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButton_arriba_abajo = new System.Windows.Forms.RadioButton();
            this.radioButton_arriba_abajo_media = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_no = new System.Windows.Forms.Label();
            this.label_n1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_alfa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label_alfa_medio = new System.Windows.Forms.Label();
            this.label_cantidad = new System.Windows.Forms.Label();
            this.label_cant_corridas = new System.Windows.Forms.Label();
            this.label_o2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_uco = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label_zo = new System.Windows.Forms.Label();
            this.label_cant_unos = new System.Windows.Forms.Label();
            this.label_cant_ceros = new System.Windows.Forms.Label();
            this.btn_aplicar_prueba = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label_respuesta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.criterio_AB = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.criterio_Med_AB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aleatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prueba)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dataGridView_aleatorios.TabIndex = 1;
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
            this.label_nombre_algoritmo.TabIndex = 2;
            this.label_nombre_algoritmo.Text = "--";
            // 
            // dataGridView_prueba
            // 
            this.dataGridView_prueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_prueba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s,
            this.Corrida});
            this.dataGridView_prueba.Location = new System.Drawing.Point(186, 29);
            this.dataGridView_prueba.Name = "dataGridView_prueba";
            this.dataGridView_prueba.Size = new System.Drawing.Size(243, 317);
            this.dataGridView_prueba.TabIndex = 20;
            // 
            // s
            // 
            this.s.HeaderText = "S";
            this.s.Name = "s";
            // 
            // Corrida
            // 
            this.Corrida.HeaderText = "Corrida";
            this.Corrida.Name = "Corrida";
            // 
            // radioButton_arriba_abajo
            // 
            this.radioButton_arriba_abajo.AutoSize = true;
            this.radioButton_arriba_abajo.Location = new System.Drawing.Point(16, 23);
            this.radioButton_arriba_abajo.Name = "radioButton_arriba_abajo";
            this.radioButton_arriba_abajo.Size = new System.Drawing.Size(88, 17);
            this.radioButton_arriba_abajo.TabIndex = 21;
            this.radioButton_arriba_abajo.TabStop = true;
            this.radioButton_arriba_abajo.Text = "Arriba - Abajo";
            this.radioButton_arriba_abajo.UseVisualStyleBackColor = true;
            this.radioButton_arriba_abajo.CheckedChanged += new System.EventHandler(this.radioButton_arriba_abajo_CheckedChanged);
            // 
            // radioButton_arriba_abajo_media
            // 
            this.radioButton_arriba_abajo_media.AutoSize = true;
            this.radioButton_arriba_abajo_media.Location = new System.Drawing.Point(16, 55);
            this.radioButton_arriba_abajo_media.Name = "radioButton_arriba_abajo_media";
            this.radioButton_arriba_abajo_media.Size = new System.Drawing.Size(126, 17);
            this.radioButton_arriba_abajo_media.TabIndex = 22;
            this.radioButton_arriba_abajo_media.TabStop = true;
            this.radioButton_arriba_abajo_media.Text = "Arriba - Abajo (Media)";
            this.radioButton_arriba_abajo_media.UseVisualStyleBackColor = true;
            this.radioButton_arriba_abajo_media.CheckedChanged += new System.EventHandler(this.radioButton_arriba_abajo_media_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_arriba_abajo);
            this.groupBox1.Controls.Add(this.radioButton_arriba_abajo_media);
            this.groupBox1.Location = new System.Drawing.Point(461, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 83);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Prueba";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Co";
            // 
            // label_no
            // 
            this.label_no.AutoSize = true;
            this.label_no.Location = new System.Drawing.Point(462, 273);
            this.label_no.Name = "label_no";
            this.label_no.Size = new System.Drawing.Size(19, 13);
            this.label_no.TabIndex = 26;
            this.label_no.Text = "n0";
            this.label_no.Visible = false;
            // 
            // label_n1
            // 
            this.label_n1.AutoSize = true;
            this.label_n1.Location = new System.Drawing.Point(462, 297);
            this.label_n1.Name = "label_n1";
            this.label_n1.Size = new System.Drawing.Size(19, 13);
            this.label_n1.TabIndex = 27;
            this.label_n1.Text = "n1";
            this.label_n1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(545, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(562, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "%";
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(507, 223);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(29, 13);
            this.label_error.TabIndex = 31;
            this.label_error.Text = "1 - α";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Error";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "α";
            // 
            // txt_alfa
            // 
            this.txt_alfa.Location = new System.Drawing.Point(508, 191);
            this.txt_alfa.Name = "txt_alfa";
            this.txt_alfa.Size = new System.Drawing.Size(46, 20);
            this.txt_alfa.TabIndex = 28;
            this.txt_alfa.TextChanged += new System.EventHandler(this.txt_alfa_TextChanged);
            this.txt_alfa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_alfa_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(461, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "α/2";
            // 
            // label_alfa_medio
            // 
            this.label_alfa_medio.AutoSize = true;
            this.label_alfa_medio.Location = new System.Drawing.Point(507, 247);
            this.label_alfa_medio.Name = "label_alfa_medio";
            this.label_alfa_medio.Size = new System.Drawing.Size(60, 13);
            this.label_alfa_medio.TabIndex = 35;
            this.label_alfa_medio.Text = "1 - (error/2)";
            // 
            // label_cantidad
            // 
            this.label_cantidad.AutoSize = true;
            this.label_cantidad.Location = new System.Drawing.Point(507, 136);
            this.label_cantidad.Name = "label_cantidad";
            this.label_cantidad.Size = new System.Drawing.Size(92, 13);
            this.label_cantidad.TabIndex = 37;
            this.label_cantidad.Text = "Cantidad numeros";
            // 
            // label_cant_corridas
            // 
            this.label_cant_corridas.AutoSize = true;
            this.label_cant_corridas.Location = new System.Drawing.Point(507, 166);
            this.label_cant_corridas.Name = "label_cant_corridas";
            this.label_cant_corridas.Size = new System.Drawing.Size(89, 13);
            this.label_cant_corridas.TabIndex = 38;
            this.label_cant_corridas.Text = "Cantidad corridas";
            // 
            // label_o2
            // 
            this.label_o2.AutoSize = true;
            this.label_o2.Location = new System.Drawing.Point(675, 160);
            this.label_o2.Name = "label_o2";
            this.label_o2.Size = new System.Drawing.Size(48, 13);
            this.label_o2.TabIndex = 44;
            this.label_o2.Text = "valor_o2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(629, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "σ^2Co";
            // 
            // label_uco
            // 
            this.label_uco.AutoSize = true;
            this.label_uco.Location = new System.Drawing.Point(675, 136);
            this.label_uco.Name = "label_uco";
            this.label_uco.Size = new System.Drawing.Size(54, 13);
            this.label_uco.TabIndex = 41;
            this.label_uco.Text = "valor_uco";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(629, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Uco";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(630, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Z0";
            // 
            // label_zo
            // 
            this.label_zo.AutoSize = true;
            this.label_zo.Location = new System.Drawing.Point(675, 186);
            this.label_zo.Name = "label_zo";
            this.label_zo.Size = new System.Drawing.Size(47, 13);
            this.label_zo.TabIndex = 45;
            this.label_zo.Text = "valor_zo";
            // 
            // label_cant_unos
            // 
            this.label_cant_unos.AutoSize = true;
            this.label_cant_unos.Location = new System.Drawing.Point(507, 297);
            this.label_cant_unos.Name = "label_cant_unos";
            this.label_cant_unos.Size = new System.Drawing.Size(78, 13);
            this.label_cant_unos.TabIndex = 47;
            this.label_cant_unos.Text = "Cantidad_unos";
            this.label_cant_unos.Visible = false;
            // 
            // label_cant_ceros
            // 
            this.label_cant_ceros.AutoSize = true;
            this.label_cant_ceros.Location = new System.Drawing.Point(507, 273);
            this.label_cant_ceros.Name = "label_cant_ceros";
            this.label_cant_ceros.Size = new System.Drawing.Size(81, 13);
            this.label_cant_ceros.TabIndex = 46;
            this.label_cant_ceros.Text = "Cantidad_ceros";
            this.label_cant_ceros.Visible = false;
            // 
            // btn_aplicar_prueba
            // 
            this.btn_aplicar_prueba.Location = new System.Drawing.Point(645, 35);
            this.btn_aplicar_prueba.Name = "btn_aplicar_prueba";
            this.btn_aplicar_prueba.Size = new System.Drawing.Size(124, 50);
            this.btn_aplicar_prueba.TabIndex = 48;
            this.btn_aplicar_prueba.Text = "Aplicar Prueba";
            this.btn_aplicar_prueba.UseVisualStyleBackColor = true;
            this.btn_aplicar_prueba.Click += new System.EventHandler(this.btn_aplicar_prueba_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(608, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Criterio - Med(AB):";
            // 
            // label_respuesta
            // 
            this.label_respuesta.AutoSize = true;
            this.label_respuesta.Location = new System.Drawing.Point(468, 333);
            this.label_respuesta.Name = "label_respuesta";
            this.label_respuesta.Size = new System.Drawing.Size(13, 13);
            this.label_respuesta.TabIndex = 53;
            this.label_respuesta.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "(-Zα/2<=Zo<=Zα/2)";
            // 
            // criterio_AB
            // 
            this.criterio_AB.AutoSize = true;
            this.criterio_AB.Location = new System.Drawing.Point(738, 224);
            this.criterio_AB.Name = "criterio_AB";
            this.criterio_AB.Size = new System.Drawing.Size(13, 13);
            this.criterio_AB.TabIndex = 51;
            this.criterio_AB.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(675, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Zo < Zα/2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Criterio - AB";
            // 
            // criterio_Med_AB
            // 
            this.criterio_Med_AB.AutoSize = true;
            this.criterio_Med_AB.Location = new System.Drawing.Point(613, 282);
            this.criterio_Med_AB.Name = "criterio_Med_AB";
            this.criterio_Med_AB.Size = new System.Drawing.Size(13, 13);
            this.criterio_Med_AB.TabIndex = 55;
            this.criterio_Med_AB.Text = "--";
            // 
            // prueba_independencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 358);
            this.Controls.Add(this.criterio_Med_AB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_respuesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.criterio_AB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_aplicar_prueba);
            this.Controls.Add(this.label_cant_unos);
            this.Controls.Add(this.label_cant_ceros);
            this.Controls.Add(this.label_zo);
            this.Controls.Add(this.label_o2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label_uco);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label_cant_corridas);
            this.Controls.Add(this.label_cantidad);
            this.Controls.Add(this.label_alfa_medio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_alfa);
            this.Controls.Add(this.label_n1);
            this.Controls.Add(this.label_no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_prueba);
            this.Controls.Add(this.label_nombre_algoritmo);
            this.Controls.Add(this.dataGridView_aleatorios);
            this.Name = "prueba_independencia";
            this.Text = "prueba_independencia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aleatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prueba)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView_aleatorios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ri;
        private System.Windows.Forms.Label label_nombre_algoritmo;
        public System.Windows.Forms.DataGridView dataGridView_prueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn s;
        private System.Windows.Forms.DataGridViewTextBoxColumn Corrida;
        private System.Windows.Forms.RadioButton radioButton_arriba_abajo;
        private System.Windows.Forms.RadioButton radioButton_arriba_abajo_media;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_no;
        private System.Windows.Forms.Label label_n1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_alfa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_alfa_medio;
        public System.Windows.Forms.Label label_cantidad;
        public System.Windows.Forms.Label label_cant_corridas;
        private System.Windows.Forms.Label label_o2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_uco;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_zo;
        public System.Windows.Forms.Label label_cant_unos;
        public System.Windows.Forms.Label label_cant_ceros;
        private System.Windows.Forms.Button btn_aplicar_prueba;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_respuesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label criterio_AB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label criterio_Med_AB;
    }
}
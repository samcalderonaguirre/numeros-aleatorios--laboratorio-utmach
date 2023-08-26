namespace Numeros_aleatorios_algoritmos
{
    partial class cuadrados_medios
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
            this.tabla_cuad_min = new System.Windows.Forms.DataGridView();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_generar = new System.Windows.Forms.Button();
            this.txt_semilla = new System.Windows.Forms.TextBox();
            this.txt_ciclo_vida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_complementar = new System.Windows.Forms.CheckBox();
            this.label_can_max_dig = new System.Windows.Forms.Label();
            this.cant_max_dig = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cant_max_aleatorio = new System.Windows.Forms.Label();
            this.btn_uniformidad = new System.Windows.Forms.Button();
            this.btn_prueba_independencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_cuad_min)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_cuad_min
            // 
            this.tabla_cuad_min.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_cuad_min.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n,
            this.Xi,
            this.Xi2,
            this.Yi,
            this.ri});
            this.tabla_cuad_min.Location = new System.Drawing.Point(40, 88);
            this.tabla_cuad_min.Name = "tabla_cuad_min";
            this.tabla_cuad_min.ReadOnly = true;
            this.tabla_cuad_min.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_cuad_min.Size = new System.Drawing.Size(543, 208);
            this.tabla_cuad_min.TabIndex = 6;
            // 
            // n
            // 
            this.n.HeaderText = "n";
            this.n.Name = "n";
            this.n.ReadOnly = true;
            // 
            // Xi
            // 
            this.Xi.HeaderText = "Xi";
            this.Xi.Name = "Xi";
            this.Xi.ReadOnly = true;
            // 
            // Xi2
            // 
            this.Xi2.HeaderText = "Xi2";
            this.Xi2.Name = "Xi2";
            this.Xi2.ReadOnly = true;
            // 
            // Yi
            // 
            this.Yi.HeaderText = "Yi";
            this.Yi.Name = "Yi";
            this.Yi.ReadOnly = true;
            // 
            // ri
            // 
            this.ri.HeaderText = "ri";
            this.ri.Name = "ri";
            this.ri.ReadOnly = true;
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(396, 22);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(87, 40);
            this.btn_generar.TabIndex = 5;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_semilla
            // 
            this.txt_semilla.Location = new System.Drawing.Point(66, 12);
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(100, 20);
            this.txt_semilla.TabIndex = 2;
            this.txt_semilla.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_semilla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_semilla_KeyPress);
            // 
            // txt_ciclo_vida
            // 
            this.txt_ciclo_vida.Location = new System.Drawing.Point(66, 48);
            this.txt_ciclo_vida.Name = "txt_ciclo_vida";
            this.txt_ciclo_vida.Size = new System.Drawing.Size(100, 20);
            this.txt_ciclo_vida.TabIndex = 3;
            this.txt_ciclo_vida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ciclo_vida_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "n";
            // 
            // checkBox_complementar
            // 
            this.checkBox_complementar.AutoSize = true;
            this.checkBox_complementar.Location = new System.Drawing.Point(218, 14);
            this.checkBox_complementar.Name = "checkBox_complementar";
            this.checkBox_complementar.Size = new System.Drawing.Size(93, 17);
            this.checkBox_complementar.TabIndex = 4;
            this.checkBox_complementar.Text = "Complementar";
            this.checkBox_complementar.UseVisualStyleBackColor = true;
            // 
            // label_can_max_dig
            // 
            this.label_can_max_dig.AutoSize = true;
            this.label_can_max_dig.Location = new System.Drawing.Point(215, 56);
            this.label_can_max_dig.Name = "label_can_max_dig";
            this.label_can_max_dig.Size = new System.Drawing.Size(123, 13);
            this.label_can_max_dig.TabIndex = 7;
            this.label_can_max_dig.Text = "Cantidad Max de digitos:";
            // 
            // cant_max_dig
            // 
            this.cant_max_dig.AutoSize = true;
            this.cant_max_dig.Location = new System.Drawing.Point(341, 57);
            this.cant_max_dig.Name = "cant_max_dig";
            this.cant_max_dig.Size = new System.Drawing.Size(13, 13);
            this.cant_max_dig.TabIndex = 8;
            this.cant_max_dig.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad Max Aleatorios:";
            // 
            // cant_max_aleatorio
            // 
            this.cant_max_aleatorio.AutoSize = true;
            this.cant_max_aleatorio.Location = new System.Drawing.Point(341, 36);
            this.cant_max_aleatorio.Name = "cant_max_aleatorio";
            this.cant_max_aleatorio.Size = new System.Drawing.Size(13, 13);
            this.cant_max_aleatorio.TabIndex = 10;
            this.cant_max_aleatorio.Text = "--";
            // 
            // btn_uniformidad
            // 
            this.btn_uniformidad.Location = new System.Drawing.Point(489, 4);
            this.btn_uniformidad.Name = "btn_uniformidad";
            this.btn_uniformidad.Size = new System.Drawing.Size(94, 39);
            this.btn_uniformidad.TabIndex = 11;
            this.btn_uniformidad.Text = "Pruebas uniformidad";
            this.btn_uniformidad.UseVisualStyleBackColor = true;
            this.btn_uniformidad.Click += new System.EventHandler(this.btn_uniformidad_Click);
            // 
            // btn_prueba_independencia
            // 
            this.btn_prueba_independencia.Location = new System.Drawing.Point(489, 45);
            this.btn_prueba_independencia.Name = "btn_prueba_independencia";
            this.btn_prueba_independencia.Size = new System.Drawing.Size(94, 39);
            this.btn_prueba_independencia.TabIndex = 12;
            this.btn_prueba_independencia.Text = "Pruebas Independencia";
            this.btn_prueba_independencia.UseVisualStyleBackColor = true;
            this.btn_prueba_independencia.Click += new System.EventHandler(this.btn_prueba_independencia_Click);
            // 
            // cuadrados_medios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 308);
            this.Controls.Add(this.btn_prueba_independencia);
            this.Controls.Add(this.btn_uniformidad);
            this.Controls.Add(this.cant_max_aleatorio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cant_max_dig);
            this.Controls.Add(this.label_can_max_dig);
            this.Controls.Add(this.checkBox_complementar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ciclo_vida);
            this.Controls.Add(this.txt_semilla);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.tabla_cuad_min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "cuadrados_medios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuadrados Medios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cuadrados_minimos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_cuad_min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_cuad_min;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.TextBox txt_semilla;
        private System.Windows.Forms.TextBox txt_ciclo_vida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ri;
        private System.Windows.Forms.CheckBox checkBox_complementar;
        private System.Windows.Forms.Label label_can_max_dig;
        private System.Windows.Forms.Label cant_max_dig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cant_max_aleatorio;
        private System.Windows.Forms.Button btn_uniformidad;
        private System.Windows.Forms.Button btn_prueba_independencia;
    }
}
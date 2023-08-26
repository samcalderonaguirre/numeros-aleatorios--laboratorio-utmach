using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_aleatorios_algoritmos
{
    public partial class pruebas_uniformidad : Form
    {
        public pruebas_uniformidad()
        {
            InitializeComponent();
        }

        pruebas_uniformidad_DAO prueba = new pruebas_uniformidad_DAO();
        generales general = new generales();

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            dataGridView_prueba.Columns.Clear();
            dataGridView_prueba.Columns.Add("N", "n°");
            dataGridView_prueba.Columns.Add("Limite_inf", "Limite inf");
            dataGridView_prueba.Columns.Add("Limite_sup", "Limite sup");
            dataGridView_prueba.Columns.Add("Oi", "Oi");
            dataGridView_prueba.Columns.Add("Ei", "Ei");
            dataGridView_prueba.Columns.Add("Xo2", "Xo^2");
            txt_intervalos.Enabled = true;
            label_respuesta.Text = "";
            txt_intervalos.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            dataGridView_prueba.Columns.Clear();
            dataGridView_prueba.Columns.Add("J", "J");
            dataGridView_prueba.Columns.Add("Xi", "Xi");
            dataGridView_prueba.Columns.Add("FnXi", "FnXi");
            dataGridView_prueba.Columns.Add("Dn", "Dn");
            txt_intervalos.Enabled = false;
            label_xo2.Text = "--";
            txt_intervalos.Clear();
            label_respuesta.Text = "";
            
        }

        private void btn_aplicar_prueba_Click(object sender, EventArgs e)
        {
            if (general.hay_seleccionado(groupBox1))
            {
                if (!txt_alfa.Text.Equals(""))
                {

                    if (!txt_valor_tabla.Text.Equals(""))
                    {


                        if (radioButton_kolmogorov.Checked)
                        {

                            if (Convert.ToInt32(label_cantidad.Text) <= 30)
                            {

                                prueba.prueba_kolmogorov(label_maxdn, dataGridView_aleatorios, dataGridView_prueba);

                                label_criterio_kolmogorov.Text = Convert.ToDouble(label_maxdn.Text) + " < " + Convert.ToDouble(txt_valor_tabla.Text);
                                if (Convert.ToDouble(label_maxdn.Text) < Convert.ToDouble(txt_valor_tabla.Text))
                                {

                                    label_respuesta.Text = "No se puede rechazar que la distribución sigue una distribución uniforme";
                                }
                                else
                                {
                                    label_respuesta.Text = "Se rechazar que la distribución sigue una distribución uniforme";

                                }
                            }
                            else
                            {
                                MessageBox.Show("La cantidad de aleatorios no puede ser mayor a 30");
                            }
                        }

                        if (radioButton_chi_cuadrado.Checked)
                        {
                            if (!txt_intervalos.Text.Equals(""))
                            {
                                prueba.prueba_chi_cuadrado(Convert.ToInt32(txt_intervalos.Text), label_xo2, dataGridView_aleatorios, dataGridView_prueba);


                                if (Convert.ToDouble(label_xo2.Text) < Convert.ToDouble(txt_valor_tabla.Text))
                                {
                                    label_respuesta.Text = "No se puede rechazar que la distribución sigue una distribución uniforme";
                                }
                                else
                                {
                                    label_respuesta.Text = "Se rechazar que la distribución sigue una distribución uniforme";

                                }

                            }
                            else
                            {
                                MessageBox.Show("Ingresa los intervalos");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("ingresa el valor de la tabla");
                    }

                }
                else
                {
                    MessageBox.Show("Ingresa el error");
                }
            }else
            {
                MessageBox.Show("Selecciona un tipo de prueba");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!txt_alfa.Text.Equals(""))
            {
                label_alfa_error.Text = (100 - Convert.ToInt32(txt_alfa.Text)).ToString();

            }else
            {
                label_alfa_error.Text = "";
            }
        }

        private void txt_intervalos_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, txt_intervalos);
        }

        private void txt_alfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, txt_alfa);
        }
    }
}

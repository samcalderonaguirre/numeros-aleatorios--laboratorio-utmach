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
    public partial class cuadrados_medios : Form
    {
        public cuadrados_medios()
        {
            InitializeComponent();
        }
        cuadrados_medios_DAO cuad_min = new cuadrados_medios_DAO();
        generales general = new generales();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_semilla.Text.Length > 3)
            {
                if (general.es_par(Convert.ToDouble(txt_semilla.Text)))
                {
                    if (!txt_ciclo_vida.Text.Equals(""))
                    {
                        try
                        {
                            cuad_min.generar_calculo(Convert.ToInt32(txt_ciclo_vida.Text), txt_semilla.Text, checkBox_complementar.Checked, Convert.ToInt32(cant_max_dig.Text), tabla_cuad_min, general);


                            if (general.cant_max_aleatorios(tabla_cuad_min, 3) == 0)
                            {
                                cant_max_aleatorio.Text = txt_ciclo_vida.Text;

                            }
                            else
                            {
                                cant_max_aleatorio.Text = general.cant_max_aleatorios(tabla_cuad_min, 3).ToString();

                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al ingresar datos");

                        }

                    }
                    else
                    {
                        MessageBox.Show("Ingresa el ciclo de vida");
                    }
                }else
                {
                    MessageBox.Show("La semilla debe ser par");
                }
            }
            else
            {
                MessageBox.Show("La semilla debe ser Mayor a 3");

            }
        }

        private void cuadrados_minimos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.principal.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            cant_max_dig.Text = general.cant_max_dig(txt_semilla.Text).ToString();
        }

        private void txt_semilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, txt_semilla);
        }

        private void txt_ciclo_vida_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, txt_ciclo_vida);
        }

        private void btn_uniformidad_Click(object sender, EventArgs e)
        {

            pruebas_uniformidad prueba_uni = new pruebas_uniformidad();

            general.pasar_aleatorios_uniformidad(tabla_cuad_min, 4, prueba_uni);


        }

        private void btn_prueba_independencia_Click(object sender, EventArgs e)
        {

            prueba_independencia prueba_ind = new prueba_independencia();

            general.pasar_aleatorios_independencia(tabla_cuad_min, 4, prueba_ind);


        }
    }
}

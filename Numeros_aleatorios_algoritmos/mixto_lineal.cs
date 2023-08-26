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
    public partial class mixto_lineal : Form
    {
        public mixto_lineal()
        {
            InitializeComponent();
        }

        mixto_lineal_DAO mixto = new mixto_lineal_DAO();
        generales general = new generales();

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (!txt_semilla.Text.Trim().Equals("") && Convert.ToInt32(txt_semilla.Text.Trim())>0)
            {
                if (!txt_ciclo_vida.Text.Trim().Equals("") && Convert.ToInt32(txt_ciclo_vida.Text.Trim()) > 0)
                {
                    if (!txt_k.Text.Trim().Equals("") && Convert.ToInt32(txt_k.Text.Trim()) > 0)
                    {
                        if (!txt_g.Text.Trim().Equals("") && Convert.ToInt32(txt_g.Text.Trim()) > 0)
                        {
                            mixto.generar_calculo(Convert.ToInt32(txt_ciclo_vida.Text), Convert.ToInt32(txt_k.Text), Convert.ToInt32(txt_g.Text), txt_semilla.Text, tabla_mixto, label_a, label_m, label_c, general);

                            if (general.cant_max_aleatorios(tabla_mixto, 2) == 0)
                            {
                                cant_max_aleatorio.Text = txt_ciclo_vida.Text;

                            }
                            else
                            {
                                cant_max_aleatorio.Text = general.cant_max_aleatorios(tabla_mixto, 3).ToString();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingresa el valor de g");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ingresa el valor de k");
                    }

                }else
                {
                    MessageBox.Show("Ingresa el valor del ciclo de vida");
                }
            }else
            {
                MessageBox.Show("Ingresa el valor de la semilla");
            }

        }

        private void mixto_lineal_FormClosing(object sender, FormClosingEventArgs e)
        {

            Program.principal.Visible = true;

        }

        private void txt_g_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, txt_ciclo_vida);
        }

        private void txt_ciclo_vida_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, txt_ciclo_vida);
        }

        private void txt_k_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, txt_ciclo_vida);
        }

        private void txt_semilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, txt_ciclo_vida);
        }

        private void btn_uniformidad_Click(object sender, EventArgs e)
        {
            pruebas_uniformidad prueba_uni = new pruebas_uniformidad();

            general.pasar_aleatorios_uniformidad(tabla_mixto, 3, prueba_uni);

        }

        private void btn_prueba_independencia_Click(object sender, EventArgs e)
        {
            prueba_independencia prueba_ind = new prueba_independencia();

            general.pasar_aleatorios_independencia(tabla_mixto, 3, prueba_ind);

        }
    }
}

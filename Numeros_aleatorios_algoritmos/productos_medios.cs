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
    public partial class productos_medios : Form
    {
        public productos_medios()
        {
            InitializeComponent();
        }

        generales general = new generales();
        productos_medios_DAO prod_med = new productos_medios_DAO();

        private void txt_semilla1_TextChanged(object sender, EventArgs e)
        {
            cant_max_dig.Text = general.cant_max_dig(txt_semilla1.Text).ToString();
        }

        private void txt_semilla2_TextChanged(object sender, EventArgs e)
        {

        }

        private void productos_medios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.principal.Show();
        }

        private void txt_semilla1_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, txt_semilla1);
        }

        private void txt_semilla2_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, txt_semilla2);
        }

        private void txt_ciclo_vida_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, txt_ciclo_vida);
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {

            if (txt_semilla1.Text.Length > 3 && txt_semilla1.Text.Length == txt_semilla2.Text.Length)
            {
                if (general.es_par(Convert.ToDouble(txt_semilla1.Text)) && general.es_par(Convert.ToDouble(txt_semilla2.Text)))
                {
                    if (!txt_ciclo_vida.Text.Equals(""))
                    {
                        try
                        {
                            prod_med.generar_calculo(Convert.ToInt32(txt_ciclo_vida.Text), txt_semilla1.Text, txt_semilla2.Text, checkBox_complementar.Checked, Convert.ToInt32(cant_max_dig.Text), tabla_cuad_min, general);

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
                    MessageBox.Show("Las semillas deben ser par");
                }
            }
            else
            {
                MessageBox.Show("La semilla debe ser Mayor a 3 y tener una longitud igual");

            }

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

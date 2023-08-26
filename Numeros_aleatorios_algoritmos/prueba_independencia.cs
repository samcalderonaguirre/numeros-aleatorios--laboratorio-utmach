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
    public partial class prueba_independencia : Form
    {

        pruebas_independencia prueba_in = new pruebas_independencia();
        generales general = new generales();
        public prueba_independencia()
        {
            InitializeComponent();
        }

        private void btn_aplicar_prueba_Click(object sender, EventArgs e)
        {
            if (general.hay_seleccionado(groupBox1))
            {
                if (!txt_alfa.Text.Equals(""))
                {
                    if (radioButton_arriba_abajo.Checked)
                    {

                        prueba_in.prueba_corrida_arriba_abajo(label_cant_corridas, dataGridView_aleatorios, dataGridView_prueba);
                        label_uco.Text = ((2 * Convert.ToDouble(label_cantidad.Text)) - (1 / 3)).ToString();
                        label_o2.Text = ((16 * Convert.ToInt32(label_cantidad.Text) - 29) / 90).ToString();
                        label_zo.Text = ((Math.Abs(Convert.ToInt32(label_cant_corridas.Text) - Convert.ToDouble(label_uco.Text))) / (Math.Pow(Convert.ToDouble(label_o2.Text), 2))).ToString();

                        criterio_AB.Text = label_zo.Text + " < " + label_alfa_medio.Text;

                        if (Convert.ToDouble(label_zo.Text) < Convert.ToDouble(label_alfa_medio.Text))
                        {

                            label_respuesta.Text = "El conjunto No es independiente";
                        }
                        else
                        {
                            label_respuesta.Text = "El conjunto es independiente";
                        }


                    }

                    if (radioButton_arriba_abajo_media.Checked)
                    {
                        prueba_in.prueba_corrida_arriba_abajo_media(label_cant_corridas, label_cant_ceros, label_cant_unos, dataGridView_aleatorios, dataGridView_prueba);
                        label_uco.Text = (((2 * Convert.ToDouble(label_cant_ceros.Text)) * Convert.ToDouble(label_cant_unos.Text) / Convert.ToDouble(label_cantidad.Text)) + 0.5).ToString();

                        double valor = (2 * Convert.ToDouble(label_cant_ceros.Text) * Convert.ToDouble(label_cant_unos.Text));

                        label_o2.Text = ((valor * (valor - Convert.ToInt32(label_cantidad.Text))) / (Math.Pow(Convert.ToInt32(label_cantidad.Text), 2) * (Convert.ToInt32(label_cantidad.Text) - 1))).ToString();

                        label_zo.Text = ((Convert.ToDouble(label_cant_corridas.Text) - Convert.ToDouble(label_uco.Text)) / (Math.Pow(Convert.ToDouble(label_o2.Text), 2))).ToString();

                        criterio_Med_AB.Text = (Convert.ToDouble(label_alfa_medio.Text) * -1) + " <= " + Convert.ToDouble(label_zo.Text) + " <= " + Convert.ToDouble(label_alfa_medio.Text);

                        if ((Convert.ToDouble(label_alfa_medio.Text) * (-1.00)) <= Convert.ToDouble(label_zo.Text) && Convert.ToDouble(label_zo.Text) <= (Convert.ToDouble(label_alfa_medio.Text)))
                        {

                            label_respuesta.Text = "El conjunto No es independiente";
                        }
                        else
                        {
                            label_respuesta.Text = "El conjunto es independiente";
                        }

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

        private void radioButton_arriba_abajo_CheckedChanged(object sender, EventArgs e)
        {

            dataGridView_prueba.Rows.Clear();
            label_no.Visible = false;
            label_n1.Visible = false;
            label_cant_ceros.Visible = false;
            label_cant_unos.Visible = false;
            label_cant_ceros.Text = "Cantidad_ceros";
            label_cant_unos.Text= "Cantidad_unos";
            label_respuesta.Text = "";
        }

        private void radioButton_arriba_abajo_media_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView_prueba.Rows.Clear();

            label_no.Visible = true;
            label_n1.Visible = true;
            label_cant_ceros.Visible = true;
            label_cant_unos.Visible = true;
            label_respuesta.Text = "";

        }

        private void txt_alfa_TextChanged(object sender, EventArgs e)
        {
            if (!txt_alfa.Equals(""))
            {
                label_error.Text = (100 - Convert.ToDouble(txt_alfa.Text)).ToString();
                label_alfa_medio.Text = (1 - ((Convert.ToDouble(label_error.Text) / 100) / 2.00)).ToString();

            }else
            {
                label_error.Text = "";
            }
        }

        private void txt_alfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, txt_alfa);
        }
    }
}

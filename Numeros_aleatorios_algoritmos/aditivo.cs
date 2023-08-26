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
    public partial class aditivo : Form
    {
        List<TextBox> lista = new List<TextBox>();

        public aditivo()
        {
            InitializeComponent();
            
        }


        aditivo_DAO adit = new aditivo_DAO();
        generales general = new generales();

        

        private void aditivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.principal.Show();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {

            if (!txt_m.Text.Trim().Equals(""))
            {
                adit.agregar_textbox(lista, groupBox1);

                adit.generar_calculo(Convert.ToInt32(txt_m.Text), lista, tabla_aditivo);


                adit.acomodar(lista, groupBox1);

                lista.Clear();

            }else
            {
                MessageBox.Show("Ingresa el valor de m");
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, textBox1);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, textBox2);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, textBox3);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, textBox4);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, textBox5);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, textBox6);
        }

        private void txt_m_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.paNumeros(sender, e, txt_m);
        }

        private void btn_uniformidad_Click(object sender, EventArgs e)
        {
            pruebas_uniformidad prueba_uni = new pruebas_uniformidad();

            general.pasar_aleatorios_uniformidad(tabla_aditivo, 3, prueba_uni);

        }

        private void btn_prueba_independencia_Click(object sender, EventArgs e)
        {
            prueba_independencia prueba_ind = new prueba_independencia();

            general.pasar_aleatorios_independencia(tabla_aditivo, 3, prueba_ind);


        }
    }
}

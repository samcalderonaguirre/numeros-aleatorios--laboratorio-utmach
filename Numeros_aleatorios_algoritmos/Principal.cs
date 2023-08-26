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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_cua_min_Click(object sender, EventArgs e)
        {

            cuadrados_medios cuad_med = new cuadrados_medios();
            cuad_med.Visible = true;

            this.Hide();
            
        }


        private void btn_prod_min_Click(object sender, EventArgs e)
        {

            productos_medios prod_med = new productos_medios();
            prod_med.Visible = true;

            this.Hide();
        }

        private void btn_congru_multi_Click(object sender, EventArgs e)
        {

            congruencial_multiplicativo congruencial = new congruencial_multiplicativo();

            congruencial.Visible = true;
            this.Hide();

        }

        private void btn_mixto_lineal_Click(object sender, EventArgs e)
        {

            mixto_lineal mixto = new mixto_lineal();

            mixto.Visible = true;
            this.Hide();

        }

        private void btn_aditivo_Click(object sender, EventArgs e)
        {
            aditivo aditivo = new aditivo();
            aditivo.Visible = true;
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pruebas_uniformidad pruebas = new pruebas_uniformidad();
            pruebas.Visible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_aleatorios_algoritmos
{
    class congruencial_multi_DAO
    {

        public congruencial_multi_DAO()
        {

        }


        public void generar_calculo(int n, int k, int g, String semilla, DataGridView tabla,GroupBox a_opcion,Label a_valor, Label m_valor,generales general)
        {

            tabla.Rows.Clear();

            int a = 0, m = 0;
            double xi = 0, ri = 0;
            
            for (int i = 0; i < n; i++)
            {

                if (general.seleccionado(a_opcion, "3+8k"))
                {
                    a = 3 + (8 * k);
                     
                }else
                {
                    a = 5 + (8 * k);
                }

                a_valor.Text = a.ToString();

                m = (int) Math.Pow(2, g);

                m_valor.Text = m.ToString();


                if (i != 0)
                {
                    semilla = tabla.Rows[(i - 1)].Cells[2].Value.ToString();

                }

                String ecuacion = "(" + a + "*" + semilla + ") mod " + m;

                xi = (a * Convert.ToDouble(semilla))%m;

                ri = xi / (m - 1);


                tabla.Rows.Add((i + 1), ecuacion,xi, Math.Truncate(ri*100000)/100000);

            }

        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_aleatorios_algoritmos
{
    class mixto_lineal_DAO
    {

        public mixto_lineal_DAO()
        {

        }

        public void generar_calculo(int n, int k, int g, String semilla, DataGridView tabla, Label a_valor, Label m_valor, Label c_valor,generales general)
        {
            tabla.Rows.Clear();

            int a = 0, m = 0;
            double xi = 0, ri = 0;

            int c = 0;

            
            Boolean primo = false;

            a = 1 + (4 * k);

            a_valor.Text = a.ToString();

            m = (int)Math.Pow(2, g);

            m_valor.Text = m.ToString();

            int aux = m-1;

            do
            {
                
                if (general.es_primo(aux))
                {
                    primo = true;
                    c = aux;
                }

                aux = aux - 1;

            } while (primo ==false);

            c_valor.Text = c.ToString();

            for (int i = 0; i < n; i++)
            {
                

                if (i != 0)
                {
                    semilla = tabla.Rows[(i - 1)].Cells[2].Value.ToString();

                }

                String ecuacion = "(" + a + "*" + semilla +"+"+c+ ") mod " + m;

                xi = (a * Convert.ToDouble(semilla) + c) % m;

                ri = xi / (m - 1);


                tabla.Rows.Add((i + 1), ecuacion, xi, Math.Truncate(ri * 100000) / 100000);

            }


        }

        


    }
}

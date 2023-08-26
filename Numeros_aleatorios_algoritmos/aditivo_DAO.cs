using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_aleatorios_algoritmos
{
    class aditivo_DAO
    {

        public aditivo_DAO()
        {

        }

        public void generar_calculo(int n,List<TextBox> lista,DataGridView tabla)
        {
            
            int total = lista.Count;
            
            if (total > 1)
            {
                tabla.Rows.Clear();

                String ecuacion = "";
                int count = n;
                double valor_ec = 0, ri = 0;

                for (int i = 0; i < n; i++)
                {

                    total = total + 1;

                    if (i == 0)
                    {
                        ecuacion = "X" + (total) + " = (" + lista[lista.Count - 1].Text + " + " + lista[i].Text + ") mod " + n;

                        valor_ec = (Convert.ToDouble(lista[lista.Count - 1].Text) + Convert.ToDouble(lista[i].Text)) % n;

                    }
                    else
                    {
                        if (i < lista.Count)
                        {
                            ecuacion = "X" + (total) + " = (" + tabla.Rows[i - 1].Cells[2].Value + " + " + lista[i].Text + ") mod " + n;

                            valor_ec = (Convert.ToDouble(tabla.Rows[i - 1].Cells[2].Value) + Convert.ToDouble(lista[i].Text)) % n;

                        }
                        else
                        {
                            ecuacion = "X" + (total) + " = (" + tabla.Rows[i - 1].Cells[2].Value + " + " + tabla.Rows[n - count].Cells[2].Value + ") mod " + n;
                            valor_ec = (Convert.ToDouble(tabla.Rows[i - 1].Cells[2].Value) + Convert.ToDouble(tabla.Rows[n - count].Cells[2].Value)) % n;

                            count = count - 1;
                        }

                    }

                    ri = valor_ec / (n - 1);

                    tabla.Rows.Add(i + 1, ecuacion, valor_ec, Math.Truncate(ri * 100000) / 100000);

                }
            }else
            {
                MessageBox.Show("Debe ser mas de una Semilla");
            }

        }


        public void agregar_textbox(List<TextBox> lista, GroupBox box)
        {
            box.Controls.OfType<TextBox>().ToList().ForEach((TextBox) =>
            {
                if (!TextBox.Text.Trim().Equals(""))
                {
                    lista.Add(TextBox);
                    

                }

            });

           
            lista.Reverse();

           
        }


        public void acomodar(List<TextBox> lista, GroupBox box)
        {
            String cad = "";
           
            for(int i = 0; i< 6; i++)
            {
                if (i < lista.Count)
                {
                    cad += lista[i].Text + ",";

                }else
                {
                    cad += ",";
                }
            }

            cad = cad.Remove(cad.Length - 1, 1);

            int count = cad.Split(',').Length-1;

            box.Controls.OfType<TextBox>().ToList().ForEach((TextBox) =>
            {

                if (count >= 0)
                {
                    TextBox.Text = cad.Split(',')[count];
                    count = count - 1;
                }

            });

        }
        

    }
}

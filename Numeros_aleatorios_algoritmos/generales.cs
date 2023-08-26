using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_aleatorios_algoritmos
{
    class generales
    {

        public generales()
        {

        }

        public Boolean es_par(double semilla)
        {
            if(semilla%2 == 0)
            {
                return true;
            }
            return false;
        }

        public void paNumeros(object sender, KeyPressEventArgs e, TextBox txt)
        {
            
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }

        }


        public String extraer_medios(String xi2, String semilla)
        {
            int aux = xi2.Length - semilla.Length;

            aux = aux / 2;

            String dato = xi2.Substring(aux, semilla.Length);

            return dato;
        }

        public String complementar_semilla(String semilla, int cant_max_dig)
        {
            String complemento = "";

            for (int i = 0; i < (cant_max_dig - semilla.Length); i++)
            {
                complemento += "0";
            }

            return complemento + semilla;

        }

        public int complementar_estimado(String semilla, String xi2, int contador)
        {

            if (xi2.Length != semilla.Length)
            {
                int mod = ((xi2.Length - semilla.Length) + contador) % 2;

                if (mod != 0)
                {
                    return complementar_estimado(semilla, xi2, (contador + 1));

                }
                else
                {
                    return xi2.Length + contador;
                }
            }
            else
            {
                xi2 = "0" + xi2;

                return complementar_estimado(semilla, xi2, contador);
            }

        }


        public int cant_max_dig(String semilla)
        {

            if (!semilla.Equals(""))
            {
                int longitud = semilla.Length;

                double num_max = Convert.ToDouble(retornar_long(longitud));

                int long_max_dig = Math.Pow(num_max, 2).ToString().Length;

                return long_max_dig;
            }

            return 0;

        }


        public String retornar_long(int longitud)
        {
            String dato = "";

            for (int i = 0; i < longitud; i++)
            {
                dato += "9";
            }

            return dato;
        }


        public int cant_max_aleatorios(DataGridView tabla,int posicion)
        {
            int pos = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {

                foreach (DataGridViewRow row2 in tabla.Rows)
                {
                    if (!(Convert.ToString(row.Cells[0].Value).Equals(Convert.ToString(row2.Cells[0].Value))))
                    {
                        
                         if (Convert.ToString(row.Cells[posicion].Value).Equals(Convert.ToString(row2.Cells[posicion].Value)))
                             {
                                
                                pos = Convert.ToInt32(row2.Cells[0].Value)-1;
                            
                                return pos;
                                 
                             }

                    }

                    
                }
                 
            }

             return pos;
        }


        public Boolean seleccionado(GroupBox box, String tipo_a)
        {
            Boolean estado = false;

            box.Controls.OfType<RadioButton>().ToList().ForEach((radiobutton) =>
            {
                if (radiobutton.Checked)
                {
                    if (radiobutton.Text.Equals(tipo_a))
                    {
                        estado = true;
                    }
                }

            });

            return estado;
        }

        public Boolean hay_seleccionado(GroupBox box)
        {
            Boolean estado = false;

            box.Controls.OfType<RadioButton>().ToList().ForEach((radiobutton) =>
            {
                if (radiobutton.Checked)
                {
                        estado = true;
                    
                }

            });

            return estado;
        }

        

        public Boolean es_primo(int numero)
        {
            if (numero > 1)
            {
                return Enumerable.Range(1, numero).Where(x => numero % x == 0)
                                 .SequenceEqual(new[] { 1, numero });
            }

            return false;
        }


        public void pasar_aleatorios_uniformidad(DataGridView tabla,int pos,pruebas_uniformidad form)
        {

            for (int i = 0; i < tabla.Rows.Count - 1; i++)
            {

                form.dataGridView_aleatorios.Rows.Add(tabla.Rows[i].Cells[pos].Value.ToString().Replace('.', ','));
            }

            form.label_cantidad.Text = (tabla.Rows.Count - 1).ToString();
            form.Visible = true;
        }



        public void pasar_aleatorios_independencia(DataGridView tabla, int pos, prueba_independencia form)
        {

            for (int i = 0; i < tabla.Rows.Count - 1; i++)
            {

                form.dataGridView_aleatorios.Rows.Add(tabla.Rows[i].Cells[pos].Value.ToString().Replace('.', ','));
            }

            form.label_cantidad.Text = (tabla.Rows.Count - 1).ToString();
            form.Visible = true;
        }

    }
}

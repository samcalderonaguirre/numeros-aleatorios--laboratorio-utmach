using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_aleatorios_algoritmos
{
    class pruebas_independencia
    {

        public pruebas_independencia()
        {

        }


        public void prueba_corrida_arriba_abajo(Label cantidad_corridas,DataGridView aleatorios, DataGridView prueba)
        {
            prueba.Rows.Clear();

            int n = aleatorios.Rows.Count;
            int s = 0;
            int corrida = 0;
            int cant_corrida = 0;
            for (int i = 0; i < n - 1; i++)
            {

                if (Convert.ToDouble(aleatorios.Rows[i+1].Cells[0].Value) <= Convert.ToDouble(aleatorios.Rows[i].Cells[0].Value))
                {
                    s = 0;
                }else
                {
                    s = 1;
                }


                corrida = sacar_corrida(prueba, i, s, corrida);

                cant_corrida += corrida;

                prueba.Rows.Add(s, corrida);

            }

            cantidad_corridas.Text = cant_corrida.ToString();
        }


        public void prueba_corrida_arriba_abajo_media(Label cantidad_corridas, Label cantidad_ceros, Label cantidad_unos, DataGridView aleatorios, DataGridView prueba)
        {
            prueba.Rows.Clear();

            int n = aleatorios.Rows.Count;
            int s = 0;
            int corrida = 0;
            int cant_corrida = 0;
            int cant_ceros = 0;
            int cant_unos = 0;

            for (int i = 0; i < n - 1; i++)
            {

                if (Convert.ToDouble(aleatorios.Rows[i].Cells[0].Value)>=0.5)
                {
                    s = 1;
                }
                else
                {
                    s = 0;
                }

                corrida = sacar_corrida(prueba, i, s, corrida);

                cant_corrida += corrida;

                if(corrida == 0)
                {
                    cant_ceros++;
                }else
                {
                    cant_unos++;
                }

                prueba.Rows.Add(s, corrida);

            }

            cantidad_corridas.Text = cant_corrida.ToString();
            cantidad_ceros.Text = cant_ceros.ToString();
            cantidad_unos.Text = cant_unos.ToString();
        }


        public int sacar_corrida(DataGridView prueba,int i ,int s, int corrida)
        {
            if (i != 0)
            {

                if (prueba.Rows[i - 1].Cells[0].Value.Equals(s))
                {
                    corrida = 0;
                }
                else
                {
                    corrida = 1;
                }

            }
            else
            {
                if (Convert.ToDouble(prueba.Rows[i].Cells[0].Value) == 0)
                {

                    corrida = 1;
                }
                else
                {
                    corrida = 0;
                }
            }

            return corrida;
        }

    }

}

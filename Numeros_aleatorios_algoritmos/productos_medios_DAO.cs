using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_aleatorios_algoritmos
{
    class productos_medios_DAO
    {
        public productos_medios_DAO()
        {

        }

        public void generar_calculo(int n, String semilla1,String semilla2, Boolean complementar, int cant_max_dig, DataGridView tabla,generales general)
        {
            tabla.Rows.Clear();
            for (int i = 0; i < n; i++)
            {

                if (i != 0)
                {
                    String numero = tabla.Rows[(i - 1)].Cells[1].Value.ToString().Split('*')[1].Trim();
                    semilla1 = numero.Substring(1,numero.Length-2);
                    semilla2 = tabla.Rows[(i - 1)].Cells[3].Value.ToString();
                }

                String xi1_xi2 = (Convert.ToDouble(semilla1) * Convert.ToDouble(semilla2)).ToString();

                if (Convert.ToDouble(semilla1) == 0)
                {
                    break;
                }

                if (complementar)
                {

                    xi1_xi2 = general.complementar_semilla(xi1_xi2, cant_max_dig);
                }
                else
                {

                    if (xi1_xi2.Length <= cant_max_dig)
                    {
                        xi1_xi2 = general.complementar_semilla(xi1_xi2, general.complementar_estimado(semilla1, xi1_xi2, 0));

                    }
                    else
                    {

                        xi1_xi2 = general.complementar_semilla(xi1_xi2, cant_max_dig);
                    }
                }

                String yi = general.extraer_medios(xi1_xi2, semilla1);
                String ri = "0." + yi;

                tabla.Rows.Add((i + 1), "("+semilla1+") "+"*"+" ("+semilla2+")", xi1_xi2, yi, ri);

            }

        }
    }
}

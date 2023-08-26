using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_aleatorios_algoritmos
{
    class cuadrados_medios_DAO
    {
        public cuadrados_medios_DAO()
        {

        }

        public void generar_calculo(int n, String semilla,Boolean complementar, int cant_max_dig, DataGridView tabla, generales general)
        {
                tabla.Rows.Clear();
                  
                for (int i = 0; i < n; i++)
                {
                
                    if (i != 0)
                    {
                        semilla = tabla.Rows[(i - 1)].Cells[3].Value.ToString();

                       
                    }

                    String xi2 = Math.Pow(Convert.ToDouble(semilla), 2).ToString();

                    if (Convert.ToDouble(semilla) == 0)
                    {
                        break;
                    }

                    if (complementar)
                    {

                        xi2 = general.complementar_semilla(xi2, cant_max_dig);
                    }
                    else
                    {
                    
                        if (xi2.Length <= cant_max_dig)
                        {
                           xi2 = general.complementar_semilla(xi2, general.complementar_estimado(semilla, xi2, 0));
                        
                        }
                        else
                        {

                            xi2 = general.complementar_semilla(xi2, cant_max_dig);
                        }
                    }
                
                    String yi = general.extraer_medios(xi2,semilla);
                    String ri = "0." + yi;
                
                    tabla.Rows.Add((i+1), semilla, xi2 , yi , ri);
                    
                }
                
        }
        

    }
}

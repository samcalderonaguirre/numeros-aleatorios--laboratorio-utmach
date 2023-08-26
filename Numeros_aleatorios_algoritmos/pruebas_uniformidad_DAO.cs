using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_aleatorios_algoritmos
{
    class pruebas_uniformidad_DAO
    {

        public pruebas_uniformidad_DAO()
        {
            

        }


        public void prueba_kolmogorov(Label maxdn,DataGridView aleatorios,DataGridView prueba)
        {
            prueba.Rows.Clear();

            aleatorios.Sort(aleatorios.Columns[0], ListSortDirection.Ascending);
            
            int n= aleatorios.Rows.Count;
            
            for (int i = 0; i < n-1; i++)
            {
                double a = i+1;
                double b = n;
                double fnxi = a / b;

                String xi = aleatorios.Rows[i].Cells[0].Value.ToString();

                double truncar = Math.Truncate(fnxi * 100) / 100;
                

                prueba.Rows.Add((i+1), xi, truncar, Math.Abs(Math.Truncate((Double.Parse(xi)-truncar)*10000)/10000));


            }

            maxdn.Text = obtener_num_mayor(prueba).ToString();

        }

        public double obtener_num_mayor(DataGridView tabla)
        {

            double mayor = 0;
           
            for (int i = 0; i < tabla.Rows.Count - 1; i++)
            {
                double num = Convert.ToDouble(tabla.Rows[i].Cells[3].Value);

                if (num > mayor)
                {
                    mayor = num;
                }

            }

            return mayor;
        }

        public void prueba_chi_cuadrado(int numero_intervalos,Label xo2, DataGridView aleatorios, DataGridView prueba)
        {

            prueba.Rows.Clear();
            
            Double incremento = Math.Round(1.00/numero_intervalos,2);
            
            Double limite_inferior = 0;
            Double limite_superior = 0;

            int n = aleatorios.Rows.Count;
            
            int cantidad = n;

            double Ei = Math.Truncate((Convert.ToDouble(cantidad) / numero_intervalos)*1000)/1000;

            String lim_in = "", lim_sup = "";

            for (int i = 0; i < numero_intervalos ; i++)
            {

                if (i != 0)
                {
                    limite_inferior = (limite_superior + (incremento / 10));
                    limite_superior = (incremento + limite_inferior) - (incremento / 10);
                    
                    lim_in = (Math.Truncate(limite_inferior * 10000) / 10000).ToString();

                    lim_sup = (Math.Truncate(limite_superior * 1000) / 1000).ToString();
                    

                    //lim_in = limite_inferior.ToString().Substring(0, 4);
                    //lim_sup = limite_superior.ToString().Substring(0, 4);

                }
                else
                {

                    limite_inferior = 0;
                    limite_superior = incremento;
                    
                    lim_in = limite_inferior.ToString();
                   lim_sup = limite_superior.ToString();
                    
                }

                 

                prueba.Rows.Add((i + 1),lim_in,lim_sup,0,Ei,0);

                
            }

            frecuencia(aleatorios, prueba);

            xo2.Text = Xo2(prueba).ToString(); 

        }

        public double Xo2(DataGridView prueba)
        {
            double acumulador = 0;

            for (int i = 0; i < prueba.Rows.Count - 1; i++)
            {
                double oi = Convert.ToDouble(prueba.Rows[i].Cells[3].Value.ToString());
                double ei = Convert.ToDouble(prueba.Rows[i].Cells[4].Value.ToString());

                prueba.Rows[i].Cells[5].Value = Math.Truncate((Math.Pow((ei-oi),2)/ei)*1000)/1000;

                acumulador += Math.Truncate((Math.Pow((ei - oi), 2) / ei) * 1000) / 1000;

            }

            return acumulador;

        }
        public void frecuencia(DataGridView aleatorios, DataGridView prueba)
        {
            for(int i = 0; i < aleatorios.Rows.Count - 1; i++)
            {

                for(int j = 0; j < prueba.Rows.Count - 1; j++)
                {

                    double xi = Convert.ToDouble(aleatorios.Rows[i].Cells[0].Value.ToString());

                  
                    if ((xi >= Convert.ToDouble(prueba.Rows[j].Cells[1].Value.ToString())) && (xi <= Convert.ToDouble(prueba.Rows[j].Cells[2].Value.ToString())))
                    {
                        
                        prueba.Rows[j].Cells[3].Value = Convert.ToInt32(prueba.Rows[j].Cells[3].Value) + 1;
                        
                    }

                }

            }
        } 

    }
}

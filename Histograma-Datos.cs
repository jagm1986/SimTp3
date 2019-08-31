using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_SIM
{
    public partial class Histograma_Datos : Form
    {
        public Histograma_Datos()
        {
            InitializeComponent();
        }

        public void graficarPoisson(double[] numeros, int cantValores, int intervalos)
        {
            lbl_Distrib_Hist.Text = "";
            lbl_Distrib_Hist.Text = "Distribucion: Poisson";
          
            double max = Generador.obtenerMaximo(numeros)+1 ;
            double min = Generador.obtenerMinimo(numeros);
            double paso = (Math.Abs(max) - Math.Abs(min)) / intervalos;
            paso = Math.Round(paso, 4);

            //creamos el vector que va a tener la frecuencia de cada intervalo
            int[] acumulados = new int[intervalos];

            for (int j = 0; j < numeros.Length; j++)        //recorremos array de numeros aleatorios
            {
                for (int l = 0; l < acumulados.Length; l++)     //for que recorre array y acumula numeros
                {
                    double tope = min + paso * (l + 1);
                    double dato = double.Parse(numeros[j].ToString());
                    if (dato < tope)
                    {
                        acumulados[l] = acumulados[l] + 1;
                        break;
                    }
                }
            }

            for (int i = 0; i < numeros.Length; i++)            //ponemos los numeros obtenidos de la distribucion solicitada en la lista
            {
                listValores.Items.Add(numeros[i]);
            }

            listIntervalos.Items.Add("Numero mayor generado: " + max);
            listIntervalos.Items.Add("Numero menor generado: " + min);
            listIntervalos.Items.Add("Ancho de intervalos: " + paso);
            listIntervalos.Items.Add("");
            double comienzo = min;
            int totalacump = 0;

            for (int t = 0; t < acumulados.Length; t++)
            {
                double tope = comienzo + paso;
                listIntervalos.Items.Add("Intervalo " + (t + 1) + " (de " + comienzo + " hasta " + tope + "):" + acumulados[t]);
                comienzo = tope;
                totalacump += (int)acumulados[t];
            }

            listIntervalos.Items.Add("");
            listIntervalos.Items.Add("");
            listIntervalos.Items.Add("Cantidad de Valores:  " + totalacump);


            //ahora graficamos frecuencias
            for (int u = 0; u < acumulados.Length; u++)
            {
                double inicio = paso * u;
                double tope = paso * (u + 1);
                double mitad = inicio + (paso / 2);
                chart_hist.Series["Frecuencia"].Points.AddXY(inicio + "-" + tope, acumulados[u]);

            }
        }
        public void graficar(double[] numeros, int cantValores, int intervalos, string distribucion)
        {
            lbl_Distrib_Hist.Text = "";
            lbl_Distrib_Hist.Text = "Distribucion: "+distribucion  ;
            double max = Math.Round((Generador.obtenerMaximo(numeros) +0.01),5) ;
            double min = Math.Round((Generador.obtenerMinimo(numeros)- 0.01),5) ;

                     
            double paso = Math.Round(((max- min) / intervalos),3);
            paso = Math.Round(paso, 4);

            //creamos el vector que va a tener la frecuencia de cada intervalo
            int[] acumulados = new int[intervalos];

            for(int j = 0; j<numeros.Length; j++)        //recorremos array de numeros aleatorios
            {
                for (int l = 0; l < acumulados.Length; l++)     //for que recorre array y acumula numeros
                {
                    double tope = min + paso * (l + 1);
                    double dato = double.Parse(numeros[j].ToString());
                    if (dato < tope)
                    {
                        acumulados[l] = acumulados[l] + 1;
                        break;
                    }
                }
            }

            for (int i = 0; i < numeros.Length; i++)            //ponemos los numeros obtenidos de la distribucion solicitada en la lista
            {
                listValores.Items.Add(numeros[i]);
            }

            listIntervalos.Items.Add("Numero mayor generado: " + max);
            listIntervalos.Items.Add("Numero menor generado: " + min);
            listIntervalos.Items.Add("Ancho de intervalos: " + paso);
            listIntervalos.Items.Add("");
           
            double comienzo = min;
            double totalacum = 0;

            for (int t = 0; t < acumulados.Length; t++)
            {
                double tope = comienzo + paso;
                listIntervalos.Items.Add("Intervalo " + (t + 1) + " (de " + comienzo + " hasta " + tope + "):" + acumulados[t]);
                comienzo = tope;
                totalacum += (int)acumulados[t];
                
            }

             listIntervalos.Items.Add("");
             listIntervalos.Items.Add("");
             listIntervalos.Items.Add("Cantidad de Valores:  "+ totalacum );
             double inicio = 0;
            //ahora graficamos frecuencias
            for (int u = 0; u < acumulados.Length; u++)
            {

                inicio = min +(paso * u);
                double tope = inicio + paso;
                double mitad = Math.Round((tope - (paso / 2)),2);
                string label = mitad.ToString();
                
                chart_hist.Series["Frecuencia"].Points.AddXY(label , acumulados[u]);
                
            }
        }

        private void btn_SalirHist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chart_hist_Click(object sender, EventArgs e)
        {

        }

        private void listIntervalos_SelectedIndexChanged(object sender, EventArgs e)
        {

        } 


    }
}

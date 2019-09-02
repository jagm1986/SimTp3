using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Statistics;

namespace TP3_SIM
{
    public partial class Histograma_Datos : Form
    {
        public Histograma_Datos()
        {
            InitializeComponent();
        }

        String error = "Este campo es númerico y debe ser entero, no acepta caracteres";
        //flag para reformular la grafica 0 = uniforme, 1 = normal, 2 = Exp, 3 = Poisson
        string tipoDistr;
        double[] backupNumeros;
        double[] esperada;
        double med, des;
        double mediaCalc;
        double chiSq;
        double k_s;

        public void graficarPoisson(double[] numeros, int cantValores, int intervalos)
        {
            tipoDistr = "Poisson";
            backupNumeros = numeros;
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
                chart_hist.Series["Frecuencia Observada"].Points.AddXY(inicio + "-" + tope, acumulados[u]);

            }
        }
        public void graficar(double[] numeros, int cantValores, int intervalos, double media, double desviacion,string distribucion)
        {
            tipoDistr = distribucion;
            esperada = new double[intervalos];
            backupNumeros = numeros;
            med = media;
            des = desviacion;
            lbl_Distrib_Hist.Text = "";
            lbl_Distrib_Hist.Text = "Distribucion: "+distribucion  ;
            double max = Math.Round((Generador.obtenerMaximo(numeros) +0.01),5) ;
            double min = Math.Round((Generador.obtenerMinimo(numeros)- 0.01),5) ;

            
            
                     
            double paso = Math.Round(((max- min) / intervalos),3);
            paso = Math.Round(paso, 4);


            switch (distribucion)
            {
                case "Uniforme":
                    double aux = numeros.Length / intervalos;
                    for (int i = 0; i < esperada.Length; i++)
                    {
                        esperada[i] = aux;
                    }
                    break;
                case "Normal":
                    for (int i = 0; i < esperada.Length; i++)
                    {
                        double frecEsp=Normal.CDF(med, des,min+paso*(i+1))- Normal.CDF(med, des, min + paso * i);
                        esperada[i] = frecEsp * cantValores;
                    }
                    
                    break;
                    
                case "Exponencial":
                    for (int i = 0; i < esperada.Length; i++)
                    {
                        double frecEsp = Exponential.CDF( 1/media, min + paso * (i + 1)) - Exponential.CDF(1/media, min + paso * i);
                        esperada[i] = frecEsp * cantValores;
                    }
                    break; //media falta esto!!
            }
            //creamos el vector que va a tener la frecuencia de cada intervalo
            int[] acumulados = new int[intervalos];
            mediaCalc = numeros[0]; chiSq = 0.0;


            for(int j = 0; j<numeros.Length; j++)        //recorremos array de numeros aleatorios
            {
                double dato = numeros[j];// double.Parse(.ToString());
                if (j > 0)
                {
                    mediaCalc = ((mediaCalc * j) + dato) / (j + 1);           //calculamos la media a cada iteracion
                }
                listValores.Items.Add(dato);                //ponemos los numeros obtenidos de la distribucion solicitada en la lista
                for (int l = 0; l < acumulados.Length; l++)     //for que recorre array y acumula frecuencias
                {
                    double tope = min + paso * (l + 1);
                    
                    if (dato < tope)
                    {
                        acumulados[l] = acumulados[l] + 1;
                        break;
                    }
                }
            }

            listIntervalos.Items.Add("Numero mayor generado: " + max);
            listIntervalos.Items.Add("Numero menor generado: " + min);
            listIntervalos.Items.Add("Ancho de intervalos: " + paso);
            listIntervalos.Items.Add("");
           
            double comienzo = min;
            double totalacum = 0;

            for (int t = 0; t < acumulados.Length; t++)   // for que recorre la el arreglo de intervalos terminado y que aprovechamos para ir calculando chi cuadrado
            {
                double tope = comienzo + paso;
                listIntervalos.Items.Add("Intervalo " + (t + 1) + " (de " + comienzo + " hasta " + tope + "):" + acumulados[t]);
                chiSq=chiSq+(Math.Pow(esperada[t]-acumulados[t],2)/esperada[t]);
                comienzo = tope;
                totalacum += acumulados[t];
                
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
                
                chart_hist.Series["Frecuencia Observada"].Points.AddXY(label , acumulados[u]);
                chart_hist.Series["Frecuencia Esperada"].Points.AddXY(label, esperada[u]);

            }
            pruebaBondad(intervalos);
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxNuevoIntervalo_TextChanged(object sender, EventArgs e)
        {
            String newInterv = textBoxNuevoIntervalo.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxNuevoIntervalo.Text, "[^0-9-]"))
            {
                MessageBox.Show(error, "Error");
                textBoxNuevoIntervalo.Text = "";
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((textBoxNuevoIntervalo.Text!="") && (double.Parse(textBoxNuevoIntervalo.Text) < 999999))
            {
                listValores.Items.Clear();
                listIntervalos.Items.Clear();
                chart_hist.Series["Frecuencia Observada"].Points.Clear();
                chart_hist.Series["Frecuencia Esperada"].Points.Clear();
                if (tipoDistr == "Poisson")
                {
                    graficarPoisson(backupNumeros, backupNumeros.Length, int.Parse(textBoxNuevoIntervalo.Text));
                }
                else
                {
                    graficar(backupNumeros, backupNumeros.Length, int.Parse(textBoxNuevoIntervalo.Text),med,des, tipoDistr);
                }
            }
            else
            {
                if (textBoxNuevoIntervalo.Text == "")
                {
                    MessageBox.Show("Ingrese una cantidad de intervalos válida", "Error");
                }
                else
                {
                    MessageBox.Show("Excedido el limite de Intervalos", "Error");
                }
                textBoxNuevoIntervalo.Text = "";
            }
        }
        private void pruebaBondad(int intervalos)
        {
            int param=2;
            if (tipoDistr == "Exponencial")
            {
                param = 1;
            }
            if (intervalos <= 3)
            {
                intervalos = 4;
            }
            double chiTabla= ChiSquared.InvCDF(intervalos - 1 - param,0.95);
            chiSq=Math.Truncate(chiSq * 10000) / 10000;
            chiTabla = Math.Truncate(chiTabla * 10000) / 10000;
            if (chiSq <= chiTabla)
            {
                labelResultadoChi.Text = chiSq + " - " + chiTabla;
                labelResChiTexto.Text = "Hipótesis Aceptada";
            } else
            {
                labelResultadoChi.Text = chiSq + " - " + chiTabla;
                labelResChiTexto.Text="Hipótesis Rechazada";
            }
        }
    }
}

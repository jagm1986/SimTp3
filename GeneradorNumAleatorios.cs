﻿
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

    public partial class GeneradorNumAleatorios : Form
    {
        public static int LIMITE_NUMERICO_TEXTBOX = 999999;
        public GeneradorNumAleatorios()
        {
            InitializeComponent();
        }


        Boolean lambda = true;

        private void GeneradorNumAleatorios_Load(object sender, EventArgs e)
        {
          //  TextBoxMedia.Enabled = false;
          //  TextBoxDesviacion.Enabled = false;
          //  TextBoxLambda.Enabled = false;
          //  TextBoxA.Enabled = false;
          //  TextBoxB.Enabled = false;
            TextBoxValores.Enabled  = false;
            TextBoxIntervalos.Enabled  = false;

            


        }
       
        public void LimpiarCampos()
        {
            TextBoxMedia.Text  = "";
            TextBoxDesviacion.Text  = "";
            TextBoxLambda.Text = "";
            TextBoxA.Text  = "";
            TextBoxB.Text = "";
            TextBoxValores.Text = "";
            TextBoxIntervalos.Text = "";
            checkPoisson.Enabled = false;
            ComboBoxDistribucion.SelectedValue  = 0;
            checkPoisson.Checked = false;

        }

        public void HabilitarCampos(String distribucion)
        {
            DesHabilitarCampos();
            TextBoxValores.Enabled = true;
            TextBoxIntervalos.Enabled = true;

            if (distribucion == "Normal")
            {
                Media.Text = "Media";
                Desviacion.Text = "Desviacion";
                TextBoxMedia.Show();
                TextBoxDesviacion.Show();

            } else if(distribucion == "Uniforme")
            {
                A.Text = "A";
                B.Text = "B";
                TextBoxA.Show();
                TextBoxB.Show();
            }
            else if (distribucion == "Exponencial")
            {
                Media.Text = "Media";
                TextBoxMedia.Show();

            }
            else if (distribucion == "Poisson")
            {
                Lambda.Text = "Lambda";
                TextBoxLambda.Show();

            }
            else 
            {
               
            }


        }

        public void DesHabilitarCampos()
        {

                TextBoxMedia.Hide();
                TextBoxA.Hide();
                TextBoxB.Hide();
               // TextBoxValores.Hide();
                //TextBoxIntervalos.Hide();
                TextBoxMedia.Hide();
                TextBoxDesviacion.Hide();
                TextBoxLambda.Hide();
                A.Text = "";
                B.Text = "";
                Lambda.Text = "";
                Media.Text = "";
                Desviacion.Text = "";




        }

        private void ComboBoxDistribucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            String distribucion = ComboBoxDistribucion.Text;
            HabilitarCampos(distribucion);
            switch (distribucion)
            {
                case "Normal":
                    LimpiarCampos();
                     TextBoxValores.Text = "10000";
                     TextBoxIntervalos.Text = "10";
                      TextBoxMedia.Text = "28";
                      TextBoxDesviacion.Text = "2";
                   
                    break;

                case "Exponencial":
                      LimpiarCampos();
                      TextBoxValores.Text = "10000";
                      TextBoxIntervalos.Text = "10";
                      TextBoxMedia.Text = "2800";
                    break;

                case "Poisson":
                    LimpiarCampos();
                    TextBoxValores.Text = "10000";
                      TextBoxIntervalos.Text = "10";
                      TextBoxLambda.Text = "15";
                      checkPoisson.Enabled = true;
                    
                    break;

                case "Uniforme":
                    LimpiarCampos();
                      TextBoxValores.Text = "10000";
                      TextBoxIntervalos.Text = "10";
                      TextBoxA.Text = "200";
                      TextBoxB.Text = "500";
                    break;

                default:
                      TextBoxMedia.Enabled = false;
                      TextBoxDesviacion.Enabled = false;
                      TextBoxLambda.Enabled = false;
                      TextBoxA.Enabled = false;
                      TextBoxB.Enabled = false;
                      LimpiarCampos();
                    break;

            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                
                Generador g = new Generador();
                Histograma_Datos histodato = new Histograma_Datos();

                double[] numeros = new double[int.Parse(TextBoxValores.Text)];
                String distribucion = ComboBoxDistribucion.Text;

                switch (distribucion)
                {
                    case "Normal":
                        numeros = g.calcularNormal(int.Parse(TextBoxValores.Text), double.Parse(TextBoxDesviacion.Text), double.Parse(TextBoxMedia.Text));
                        histodato.graficar(numeros, int.Parse(TextBoxValores.Text), int.Parse(TextBoxIntervalos.Text), double.Parse(TextBoxMedia.Text), double.Parse(TextBoxDesviacion.Text), distribucion );
                       
                        break;

                    case "Exponencial":
                        double lambda_ = 1/double.Parse(TextBoxMedia.Text);  // cambiar por double.Parse(TextBoxLambda.Text)
                        numeros = g.calcularExponencial(int.Parse(TextBoxValores.Text), 1/lambda_);
                        histodato.graficar(numeros, int.Parse(TextBoxValores.Text), int.Parse(TextBoxIntervalos.Text), 1/lambda_,1/Math.Pow(lambda_,2) , distribucion );
                        break;

                    case "Poisson":
                        double lmda;
                        if (lambda)
                        {
                            lmda = double.Parse(TextBoxLambda.Text);
                        }
                        else
                        {
                            lmda = Math.Abs(1 / double.Parse(TextBoxMedia.Text));
                        }

                        numeros = g.calcularPoisson(int.Parse(TextBoxValores.Text), lmda);
                        histodato.graficarPoisson(numeros, int.Parse(TextBoxValores.Text), int.Parse(TextBoxIntervalos.Text));
                        checkPoisson.Enabled = true;
                        break;

                    case "Uniforme":
                        double a = double.Parse(TextBoxA.Text);
                        double b = double.Parse(TextBoxB.Text);
                        numeros = g.calcularUniforme(int.Parse(TextBoxValores.Text), a,b);
                        histodato.graficar(numeros, int.Parse(TextBoxValores.Text), int.Parse(TextBoxIntervalos.Text), (b+a)/2.0, Math.Pow(b-a,2)/2.0, distribucion );
                        break;

                    default:
                        break;
                }
                
                LimpiarCampos();
                histodato.Show();
                checkPoisson.Enabled = false ;
                checkPoisson.Checked = false;
                
                
            }
            else
            {
                
                
                    MessageBox.Show("Ups! No ingreso todos los parametros requeridos para la distribucion :( ");
                
            }
        }

        String error = "Este campo es númerico, no acepta caracteres";

        private Boolean validar()
        {
            Boolean ret = true;
            if (ComboBoxDistribucion.Text == "Normal")
            {
                if (TextBoxDesviacion.Text == "" || double.Parse(TextBoxDesviacion.Text) > LIMITE_NUMERICO_TEXTBOX)
                    ret = false;
                if (TextBoxMedia.Text == "" || double.Parse(TextBoxMedia.Text) > LIMITE_NUMERICO_TEXTBOX)
                    ret = false;


                //if ( TextBoxDesviacion.Text != "  ," && TextBoxMedia.Text != "   ,"  && double.Parse(TextBoxDesviacion.Text) > double.Parse(TextBoxMedia.Text))
                //{
                //    ret = false;
                //    MessageBox.Show("La desviacion no debe ser mayor que la media", "Error", MessageBoxButtons.OK);
                //}
            


            }

            if (ComboBoxDistribucion.Text == "Uniforme")
            {
               

               if (TextBoxA.Text == "" || double.Parse(TextBoxA.Text) > LIMITE_NUMERICO_TEXTBOX)
                    ret = false;
                if (TextBoxB.Text == "" || double.Parse(TextBoxA.Text) > LIMITE_NUMERICO_TEXTBOX)
                    ret = false;
            
              
                
            }

            if (ComboBoxDistribucion.Text == "Poisson")
            {
                if (TextBoxLambda.Text == "" || double.Parse(TextBoxLambda.Text) > LIMITE_NUMERICO_TEXTBOX)
                    if (TextBoxMedia.Text == "")
                    {

                        ret = false;

                    }
            }

            if (ComboBoxDistribucion.Text == "Exponencial")
            {
                if (TextBoxMedia.Text == "" || double.Parse(TextBoxMedia.Text) > LIMITE_NUMERICO_TEXTBOX)
                    ret = false;
            }

            if (TextBoxValores.Text == "" || double.Parse(TextBoxValores.Text) > LIMITE_NUMERICO_TEXTBOX)
                ret = false;
            if (TextBoxIntervalos.Text == "" || double.Parse(TextBoxIntervalos.Text) > LIMITE_NUMERICO_TEXTBOX)
                ret = false;

            return ret;
        }

        private void consignaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consigna consigna = new Consigna();
            consigna.Show();
        }

        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca acerca = new Acerca();
            acerca.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxValores_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxValores.Text, "[^0-9]"))
            {
                MessageBox.Show(error, "Error");
                TextBoxValores.Text = "";
            }
        }

        private void TextBoxIntervalos_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxIntervalos.Text, "[^0-9]"))
            {
                MessageBox.Show(error, "Error");
                TextBoxIntervalos.Text = "";
            }
        }

        private void TextBoxMedia_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxMedia.Text, "[^0-9,.-]"))
            {
                MessageBox.Show(error, "Error");
                TextBoxMedia.Text = "";
            }
        }

        private void TextBoxDesviacion_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxDesviacion.Text, "[^0-9,.-]"))
            {
                MessageBox.Show(error, "Error");
                TextBoxDesviacion.Text = "";
            }
        }

        private void TextBoxLambda_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxLambda.Text, "[^0-9,.]"))
            {
                
                MessageBox.Show(error, "Error");
                TextBoxLambda.Text = "";
            }
        }

        private void TextBoxA_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxA.Text, "[^0-9,.-]"))
            {
                MessageBox.Show(error, "Error");
                TextBoxA.Text = "";
            }
        }

        private void TextBoxB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxB.Text, "[^0-9,.-]"))
            {
                MessageBox.Show(error, "Error");
                TextBoxB.Text = "";
            }
        }

        private void checkPoisson_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPoisson.Checked)
            {
                TextBoxLambda.Text = "";
                TextBoxLambda.Enabled = false;
                TextBoxMedia.Show();
                Media.Text = "Media";
                Lambda.Text = "";
                lambda = false;
                TextBoxLambda.Hide();


            }
            else
            {
                lambda = true;
                LimpiarCampos();
                TextBoxLambda.Enabled = true;
                Lambda.Text = "Lambda";
                Media.Text = "";
                TextBoxMedia.Hide();
                TextBoxValores.Text = "10000";
                TextBoxIntervalos.Text = "10";
                TextBoxLambda.Text = "15";
                checkPoisson.Enabled = true;
                TextBoxLambda.Show();
            }
        }     
    }
}


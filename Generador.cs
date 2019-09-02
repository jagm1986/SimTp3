using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_SIM
{
    class Generador
    {
        double[] numeros;


        //Metodo que devuelve el valor Minimo de la lista de numeros - usado para los intervalos y la grafica
        public static double obtenerMinimo(double[] vector)
        {
            double minimo = vector.Min();
            //foreach (double num in vector)
            //{
            //    if (num < minimo)
            //    {
            //        minimo = num;
            //    }
            //}
            return minimo;
        }

        //Metodo que devuelve el valor Máximo de la lista de numeros - usado para los intervalos y la grafica
        public static double obtenerMaximo(double[] vector)
        {
            
            double maximo = vector.Max();
            //foreach (double num in vector)
            //{
            //    {
            //        if (num > maximo)
            //        {
            //            maximo = num;
            //        }
            //    }            

            //}
            return maximo;
        }


        private void calcularLenguaje(int tope,int dec)
        {
            numeros = new double[tope];
            Random rnd = new Random();

            for (int i = 0; i < tope; i++)
            {
                double valor = rnd.NextDouble();
                numeros[i] = truncar(valor,dec);
                
            }
        }


        private double truncar(double number, int decimales)
        {
            double div = Math.Pow(10, decimales);
            return Math.Truncate(number * div) / div;
        }


        //Superior --> b ;  Inferior --> a;
        public double[] calcularUniforme(int tope, double inferior, double superior)
        {
            int i = 0;
            if (superior < inferior)
            {
                double aux = superior;
                superior = inferior;
                inferior = aux;
            }
            calcularLenguaje(tope,4);
            foreach (double num in numeros)
            {
                double valor = inferior + num * (superior - inferior);
                numeros[i] = valor;
                i++;
            }
            return numeros;
        }

        public double[] calcularExponencial(int tope, double media)
        {
            int i = 0;
            calcularLenguaje(tope,6);
            foreach (double num in numeros)
            {
                double valor = (-media) * Math.Log(1 - num);
                numeros[i] = truncar(valor,4);
                i++;
            }
            return numeros;
        }

        public double[] calcularNormal(int tope, double desviacion, double media)
        {
            calcularLenguaje(tope,6);
            Random rnd = new Random();
            //double[] aux = generarRandomExtra(tope,6);
            double z, valor;
            for (int i = 0; i < numeros.Length; i++)
            {
                z = Math.Sqrt(-2 * Math.Log(numeros[i])) * Math.Cos(2 * Math.PI * rnd.NextDouble()) ;
                valor = media + z * desviacion;
                numeros[i] = truncar(valor,4);
            }
            return numeros;
        }

        public double[] calcularPoisson(int tope, double lambda)
        {
            calcularLenguaje(tope,4);
            Random rnd = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                double p = 1;
                double x = 0;
                double a = Math.Exp((-1) * lambda);
                do
                {
                    p = p * rnd.NextDouble();
                    x += 1;
                }
                while (p >= a);

                numeros[i] = x;

            }
            return numeros;
        }
        
    }
}

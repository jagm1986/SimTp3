using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_SIM
{
    class Generador
    {

        public static double obtenerMinimo(double[] vector)
        {
            double minimo = vector[0];
            foreach (double num in vector)
            {
                if (num < minimo)
                {
                    minimo = num;
                }
            }
            return minimo;
        }

        public static double obtenerMaximo(double[] vector)
        {
            double maximo = vector[0];
            foreach (double num in vector)
            {
                {
                    if (num > maximo)
                    {
                        maximo = num;
                    }
                }            

            }
            return maximo;
        }

        private double[] calcularLenguaje(int tope)
        {
            double[] numeros = new double[tope];
            Random rnd = new Random();

            for (int i = 0; i < tope; i++)
            {
                double valor = rnd.NextDouble();
                numeros[i] = ((double)((int)(valor * 1000000))) / 1000000;
            }

            return numeros;
        }

        public double[] calcularUniforme(int tope, double inferior, double superior)
        {
            int i = 0;
            double[] numeros = new double[tope];
            foreach (double num in calcularLenguaje(tope))
            {
                if (superior > inferior)
                {
                    double valor = inferior + num * (superior - inferior);
                    numeros[i] = ((double)((int)(valor * 10000))) / 10000;
                    i++;
                }
                else
                {
                    double valor =superior + num * (inferior-superior);
                    numeros[i] = ((double)((int)(valor * 10000))) / 10000;
                    i++;
                }
            }
            return numeros;
        }

        public double[] calcularExponencial(int tope, double media)
        {
            int i = 0;
            double[] numeros = new double[tope];
            foreach (double num in calcularLenguaje(tope))
            {
                double valor = (-media) * Math.Log(1 - num);
                numeros[i] = ((double)((int)(valor * 10000))) / 10000;
                i++;
            }
            return numeros;
        }

        public double[] calcularNormal(int tope, double desviacion, double media)
        {
            double[] numeros = new double[tope];
            double[] aux = calcularLenguaje(tope * 12);
            int a = 0;
            double acumula = 0;

            for (int i = 0; i < aux.Length; i++)
            {
                acumula += aux[i];

                if ((i + 1) % 12 == 0)
                {
                    double valor = ((acumula + 6) * desviacion) + media;
                    numeros[a] = ((double)((int)(valor * 10000))) / 10000;
                    a++;
                    acumula = 0;
                }
            }
            return numeros;
        }

        public double[] calcularPoisson(int tope, double lambda)
        {
            double[] numeros = new double[tope];
            Random rnd = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                double p = 1;
                double x = 0;
                double a = Math.Exp(((-1) * lambda));
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

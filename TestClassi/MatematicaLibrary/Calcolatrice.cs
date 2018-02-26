using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaLibrary
{
    public static class Calcolatrice
    {
        public static double Somma(double a, double b)
        {
            double somma;
            somma = a + b;
            return somma;
        }

        public static double Pari(double a)
        {
            double risposta;
            double resto = a % 2;
            if (resto == 0)
            {
                risposta = a * 1.10;
            }
            else
            {
                risposta = a;
            }
            return risposta;
        }
    }
}


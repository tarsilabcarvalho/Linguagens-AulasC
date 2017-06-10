using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Caixa
    {

        public static double valorCerveja = 5.00;

        public static double valorRefrigerante = 3.00;

        public static double valorCoxinha = 2.50;

        public static double valorSopa = 10.00;

        public static int totalCerveja = 0;

        public static int totalRefrigerante = 0;

        public static int totalSopa = 0;

        public static int totalCoxinha = 0;

        public static double valorTotalCerveja = 0;

        public static double valorTotalRefrigerante = 0;

        public static double valorTotalSopa = 0;

        public static double valorTotalCoxinha = 0;

        public static void setCerveja(int qtdCerveja)
        {
            totalCerveja += qtdCerveja;
            valorTotalCerveja = (valorCerveja * qtdCerveja);
        }

        public static void setRefrigerante(int qtdRefrigerante)
        {
            valorTotalRefrigerante += (valorRefrigerante * qtdRefrigerante);
            totalRefrigerante += qtdRefrigerante;
        }

        public static void setSopa(int qtdSopa)
        {
            valorTotalSopa += (valorSopa * qtdSopa);
            totalSopa += qtdSopa;
        }

        public static void setCoxinha(int qtdCoxinha)
        {
            valorTotalCoxinha += (valorCoxinha * qtdCoxinha);
            totalCoxinha += qtdCoxinha;
        }

        public int getTotalCerveja()
        {
            return totalCerveja;
        }

        public int getTotalRefrigerante()
        {
            return totalRefrigerante;
        }

        public int getTotalSopa()
        {
            return totalSopa;
        }

        public int getTotalCoxinha()
        {
            return totalCoxinha;
        }


        public double getValorTotalCerveja()
        {
            return valorTotalCerveja;
        }

        public double getValorTotalRefrigerante()
        {
            return valorTotalRefrigerante;
        }

        public double getValorTotalSopa()
        {
            return valorTotalSopa;
        }

        public double getValorTotalCoxinha()
        {
            return valorTotalCoxinha;
        }

        public double getValorTotal()
        {
            return valorTotalCoxinha + valorTotalRefrigerante + valorTotalCerveja;
        }


    }
}

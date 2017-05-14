using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Time
    {
        private int Ano; 
        private int Mes;
        private int Dia;
        private int Hora;
        private int Minuto;
        private int Segundo;
        //metodos de acesso publico
        public void ExibirHoraAtual()
        {
            System.Console.WriteLine(" {0}/{1}/{2} --- {3}:{4}:{5} ", Dia, Mes, Ano, Hora, Minuto, Segundo);
        }

        public Time(System.DateTime dt)
        {
            Ano = dt.Year;
            Mes = dt.Month;
            Dia = dt.Day;
            Hora = dt.Hour;
            Minuto = dt.Minute;
            Segundo = dt.Second;
        }



    }
}


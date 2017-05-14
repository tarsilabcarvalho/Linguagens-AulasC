using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime currentTime = System.DateTime.Now;
            Time oTime = new Time(currentTime);
            oTime.ExibirHoraAtual();

            Console.ReadLine(); //faz parar o console na tela

        }
    }
}

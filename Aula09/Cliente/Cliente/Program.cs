using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(10, "Tarsila");
            cliente.exibirCliente();
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    class Cliente
    {

        int codigo;
        string nome;
        public Cliente(int cod, string nom)
        {
            codigo = cod;
            nome = nom;

        }

        public void exibirCliente()
        {
            System.Console.WriteLine("Exibindo Cliente: {0} - {1}", this.codigo, this.nome);
        }
    }
}

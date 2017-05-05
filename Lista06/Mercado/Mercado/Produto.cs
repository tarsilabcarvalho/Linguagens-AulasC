using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    class Produto
    {
        private string _nome;
        private double _valor;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public string VerificarValor()
        {
            string msg;
            if (Valor > 200)
                msg = "Desconto permitido de até 15% neste produto";
            else
                msg = "Desconto não permitido neste produto";
            return msg;
        }
    }
}

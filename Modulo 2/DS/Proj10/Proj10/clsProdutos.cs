using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Proj10
{
    internal class clsProdutos
    {
        private Double _preco;
        private int _qntd,_parcelas;
        private String _forPagamento;

        public int qntd
        {
            get { return _qntd; }
            set { _qntd = value; }
        }
        public int parcelas
        {
            get { return _parcelas; }
            set { _parcelas = value; }
        }
        public double preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
        public String forPagamento
        {
            get { return _forPagamento; }
            set { _forPagamento = value; }
        }

        public double valorTotal()
        {
            double valorTotal = 0;
            if(forPagamento == "Pix")
            {
                valorTotal = _preco * _qntd;
            }
            else if (forPagamento == "Crédito")
            {
                if (parcelas == 5)
                {
                    valorTotal = (_preco * _qntd) /5;
                }
                else if (parcelas == 10)
                {
                    valorTotal = (_preco * _qntd) /5;
                }
            }
            return valorTotal;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Pagamento_Interface
{
    internal class Produto : IPagavel
    {
        public string Nome {  get; set; }
        public double PrecoUnitario { get; set; }
        public int  Quantidade { get; set; }

        public double CalcularPagamento()
        {
            return PrecoUnitario * Quantidade;
        }
    }
    public class Servico : IPagavel
    {
        public string Nome { get; set; }
        public double TaxaHoraria { get; set; }
        public int HorasTrabalhadas { get; set; }

        public double CalcularPagamento()
        {
            return TaxaHoraria * HorasTrabalhadas;
        }
    }
}

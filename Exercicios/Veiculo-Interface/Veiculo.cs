using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Veiculo_Interface
{
    internal class Veiculo : IPilotavel, IVoavel
    {
        public void Pilotar()
        {
            Console.WriteLine("Veículo está pilotando");
        }

        public void Voar()
        {
            Console.WriteLine("Veículo está voando");
        }
    }
}

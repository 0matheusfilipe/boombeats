using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Forma_Interface
{
    internal class Circulo : IForma
    {
        double Raio {  get; set; }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
    }

    internal class Retangulo : IForma
    {
        double Base { get; set; }
        double Altura { get; set; }
        public double CalcularArea()
        {
            return Base * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}

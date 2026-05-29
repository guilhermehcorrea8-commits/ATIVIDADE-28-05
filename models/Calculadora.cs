using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public class Calculadora : ICalculadora
    {
        public string Nome { get; set; }

        public double Somar(int a, int b)
        {
            return a + b;
        }

        public double Subtrair(int a, int b)
        {
            return a - b;
        }

        public double Multiplicar(int a, int b)
        {
            return a * b;
        }

        public double Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException(
                    "Não é possível dividir por zero."
                );
            }

            return (double)a / b;
        }
    }
}
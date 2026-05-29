using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public abstract class Conta
    {
        public double Saldo { get; protected set; }

        public abstract void Creditar(double valor);

        public virtual void ExibirSaldo()
        {
            Console.WriteLine(
                $"Saldo atual: R$ {Saldo:F2}"
            );
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public class Corrente : Conta
    {
        private double Tarifa { get; set; } = 2.50;

        public override void Creditar(double valor)
        {
            Saldo += valor - Tarifa;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public sealed class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine(
                $"Sou o professor {Nome} e meu salário é R$ {Salario:F2}"
            );
        }
    }
}
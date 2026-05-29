using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine(
                $"Meu nome é {Nome} e minha nota é {Nota}"
            );
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public abstract class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }

        public abstract void Apresentar();
    }
}
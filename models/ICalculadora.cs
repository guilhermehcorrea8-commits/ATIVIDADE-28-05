using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public interface ICalculadora
    {
        public string Nome { get; set; } 
        double Somar(int a, int b);
        double Subtrair(int a, int b);
        double Multiplicar(int a, int b);

        double Dividir(int a, int b);

    }
}
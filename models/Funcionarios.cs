using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static aula_28._05.models.Interfaces;

namespace aula_28._05.models
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBase { get; set; }

        public Funcionario(
            string nome,
            double salarioBase)
        {
            Nome = nome;
            SalarioBase = salarioBase;
        }

        public abstract double CalcularSalario();
    }

    // ==========================
    // GERENTE
    // ==========================
    public class Gerente :
        Funcionario,
        IRelatorio
    {
        public Gerente(
            string nome,
            double salario)
            : base(nome, salario)
        {
        }

        public override double CalcularSalario()
        {
            return SalarioBase * 1.20;
        }

        public void ExibirRelatorio()
        {
            Console.WriteLine(
                $"Gerente: {Nome}");

            Console.WriteLine(
                $"Salário Final: R$ {CalcularSalario():F2}");
        }
    }

    // ==========================
    // DESENVOLVEDOR
    // ==========================
    public class Desenvolvedor :
        Funcionario,
        IRelatorio
    {
        public Desenvolvedor(
            string nome,
            double salario)
            : base(nome, salario)
        {
        }

        public override double CalcularSalario()
        {
            return SalarioBase * 1.10;
        }

        public void ExibirRelatorio()
        {
            Console.WriteLine(
                $"Desenvolvedor: {Nome}");

            Console.WriteLine(
                $"Salário Final: R$ {CalcularSalario():F2}");
        }
    }

    // ==========================
    // ESTAGIÁRIO
    // ==========================
    public class Estagiario :
        Funcionario,
        IRelatorio
    {
        public Estagiario(
            string nome,
            double salario)
            : base(nome, salario)
        {
        }

        public override double CalcularSalario()
        {
            return SalarioBase;
        }

        public void ExibirRelatorio()
        {
            Console.WriteLine(
                $"Estagiário: {Nome}");

            Console.WriteLine(
                $"Salário Final: R$ {CalcularSalario():F2}");
        }
    }
}
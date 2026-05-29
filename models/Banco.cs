using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public class Banco
    {
        // ==========================
        // INTERFACE
        // ==========================
        public interface ITransferencia
        {
            void Transferir(
                Conta destino,
                double valor);
        }

        // ==========================
        // CLASSE ABSTRATA
        // ==========================
        public abstract class Conta
        {
            public int Numero { get; set; }
            public double Saldo { get; set; }

            private List<string> extrato =
                new List<string>();

            public Conta(
                int numero,
                double saldo)
            {
                Numero = numero;
                Saldo = saldo;
            }

            public void Depositar(
                double valor)
            {
                Saldo += valor;

                extrato.Add(
                    $"Depósito: +R$ {valor:F2}");
            }

            public virtual void Sacar(
                double valor)
            {
                if (valor > Saldo)
                {
                    Console.WriteLine(
                        "Saldo insuficiente.");
                    return;
                }

                Saldo -= valor;

                extrato.Add(
                    $"Saque: -R$ {valor:F2}");
            }

            public void MostrarExtrato()
            {
                Console.WriteLine(
                    $"Extrato Conta {Numero}");

                foreach (string item in extrato)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine(
                    $"Saldo Atual: R$ {Saldo:F2}");
            }

            public abstract double CalcularTaxa();
        }

        // ==========================
        // CONTA CORRENTE
        // ==========================
        public class ContaCorrente :
            Conta,
            ITransferencia
        {
            public ContaCorrente(
                int numero,
                double saldo)
                : base(numero, saldo)
            {
            }

            public override double CalcularTaxa()
            {
                return 15;
            }

            public void Transferir(
                Conta destino,
                double valor)
            {
                if (valor <= Saldo)
                {
                    Sacar(valor);
                    destino.Depositar(valor);

                    Console.WriteLine(
                        "Transferência realizada.");
                }
            }
        }

        // ==========================
        // CONTA POUPANÇA
        // ==========================
        public class ContaPoupanca :
            Conta,
            ITransferencia
        {
            public ContaPoupanca(
                int numero,
                double saldo)
                : base(numero, saldo)
            {
            }

            public override double CalcularTaxa()
            {
                return 5;
            }

            public void Transferir(
                Conta destino,
                double valor)
            {
                if (valor <= Saldo)
                {
                    Sacar(valor);
                    destino.Depositar(valor);

                    Console.WriteLine(
                        "Transferência realizada.");
                }
            }
        }
    }
}
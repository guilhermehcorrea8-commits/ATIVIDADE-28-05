using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static aula_28._05.models.Interfaces;

namespace aula_28._05.models
{
    public class Pagamentos
    {
        // ==========================
        // FORMAS DE PAGAMENTO
        // ==========================
        public class CartaoCredito : IPagamento
        {
            public void Pagar(double valor)
            {
                Console.WriteLine($"Pagamento de R$ {valor:F2} realizado no cartão de crédito.");
            }
        }

        public class Pix : IPagamento
        {
            public void Pagar(double valor)
            {
                Console.WriteLine($"Pagamento PIX de R$ {valor:F2} realizado com sucesso.");
            }
        }

        public class Boleto : IPagamento
        {
            public void Pagar(double valor)
            {
                Console.WriteLine($"Boleto de R$ {valor:F2} gerado.");
            }
        }

        // ==========================
        // PEDIDOS
        // ==========================
        public abstract class Pedido
        {
            public int Numero { get; set; }
            public double ValorTotal { get; set; }

            public Pedido(int numero, double valor)
            {
                Numero = numero;
                ValorTotal = valor;
            }

            public abstract void FinalizarPedido();
        }

        public class PedidoOnline : Pedido
        {
            public PedidoOnline(int numero, double valor)
                : base(numero, valor)
            {
            }

            public override void FinalizarPedido()
            {
                Console.WriteLine($"Pedido Online #{Numero} finalizado.");
            }
        }

        public class PedidoLoja : Pedido
        {
            public PedidoLoja(int numero, double valor)
                : base(numero, valor)
            {
            }

            public override void FinalizarPedido()
            {
                Console.WriteLine($"Pedido Loja #{Numero} finalizado.");
            }
        }
    }
}

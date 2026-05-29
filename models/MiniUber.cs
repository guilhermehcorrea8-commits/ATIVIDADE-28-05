using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public class MiniUber
    {
        // ==========================
        // INTERFACE
        // ==========================
        public interface ILocalizacao
        {
            void AtualizarLocalizacao();
        }

        // ==========================
        // CLASSE ABSTRATA
        // ==========================
        public abstract class VeiculoAplicativo
        {
            public string Placa { get; set; }
            public string Modelo { get; set; }
            public double QuilometrosRodados { get; set; }
            public int QuantidadeCorridas { get; set; }

            public VeiculoAplicativo(
                string placa,
                string modelo)
            {
                Placa = placa;
                Modelo = modelo;
                QuilometrosRodados = 0;
                QuantidadeCorridas = 0;
            }

            public abstract double CalcularCorrida(
                double quilometros);
        }

        // ==========================
        // CARRO UBER
        // ==========================
        public class CarroUber :
            VeiculoAplicativo,
            ILocalizacao
        {
            public CarroUber(
                string placa,
                string modelo)
                : base(placa, modelo)
            {
            }

            public override double CalcularCorrida(
                double quilometros)
            {
                double valor =
                    quilometros * 2.50;

                QuilometrosRodados +=
                    quilometros;

                QuantidadeCorridas++;

                return valor;
            }

            public void AtualizarLocalizacao()
            {
                Console.WriteLine(
                    $"Carro {Modelo} atualizado.");
            }
        }

        // ==========================
        // MOTO UBER
        // ==========================
        public class MotoUber :
            VeiculoAplicativo,
            ILocalizacao
        {
            public MotoUber(
                string placa,
                string modelo)
                : base(placa, modelo)
            {
            }

            public override double CalcularCorrida(
                double quilometros)
            {
                double valor =
                    quilometros * 1.50;

                QuilometrosRodados +=
                    quilometros;

                QuantidadeCorridas++;

                return valor;
            }

            public void AtualizarLocalizacao()
            {
                Console.WriteLine(
                    $"Moto {Modelo} atualizada.");
            }
        }
    }
}
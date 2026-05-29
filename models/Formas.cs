using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public class Formas
    {
        // ==========================
        // INTERFACE
        // ==========================
        public interface IDesenho
        {
            void Desenhar();
        }

        // ==========================
        // CLASSE ABSTRATA
        // ==========================
        public abstract class Forma
        {
            public abstract double CalcularArea();
        }

        // ==========================
        // QUADRADO
        // ==========================
        public class Quadrado : Forma, IDesenho
        {
            public double Lado { get; set; }

            public Quadrado(double lado)
            {
                Lado = lado;
            }

            public override double CalcularArea()
            {
                return Lado * Lado;
            }

            public void Desenhar()
            {
                Console.WriteLine("Desenhando Quadrado");
            }
        }

        // ==========================
        // RETÂNGULO
        // ==========================
        public class Retangulo : Forma, IDesenho
        {
            public double Base { get; set; }
            public double Altura { get; set; }

            public Retangulo(
                double baseRetangulo,
                double altura)
            {
                Base = baseRetangulo;
                Altura = altura;
            }

            public override double CalcularArea()
            {
                return Base * Altura;
            }

            public void Desenhar()
            {
                Console.WriteLine(
                    "Desenhando Retângulo");
            }
        }

        // ==========================
        // CÍRCULO
        // ==========================
        public class Circulo : Forma, IDesenho
        {
            public double Raio { get; set; }

            public Circulo(double raio)
            {
                Raio = raio;
            }

            public override double CalcularArea()
            {
                return Math.PI * Raio * Raio;
            }

            public void Desenhar()
            {
                Console.WriteLine(
                    "Desenhando Círculo");
            }
        }
    }
}
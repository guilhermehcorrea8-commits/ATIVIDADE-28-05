using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static aula_28._05.models.Interfaces;

namespace aula_28._05.models
{
    public abstract class Veiculos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int VelocidadeAtual { get; set; }

        public Veiculos(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            VelocidadeAtual = 0;
        }

        public abstract void Acelerar();

        public virtual void Frear()
        {
            VelocidadeAtual -= 10;

            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }
        }
    }

    // ==========================
    // CARRO
    // ==========================
    public class Carro : Veiculos, IBuzina
    {
        public Carro(string marca, string modelo)
            : base(marca, modelo)
        {
        }


        public override void Acelerar()
        {
            VelocidadeAtual += 10;
        }

        public void Buzinar()
        {
            Console.WriteLine("Carro: Biiiii Biiiii!");
        }
        // ==========================
        // MOTO
        // ==========================
        public class Moto : Veiculos, IBuzina
        {
            public Moto(string marca, string modelo)
                : base(marca, modelo)
            {
            }

            public override void Acelerar()
            {
                VelocidadeAtual += 15;
            }

            public override void Frear()
            {
                VelocidadeAtual -= 15;

                if (VelocidadeAtual < 0)
                {
                    VelocidadeAtual = 0;
                }
            }

            public void Buzinar()
            {
                Console.WriteLine("Moto: Beep Beep!");
            }
        }
    }
}
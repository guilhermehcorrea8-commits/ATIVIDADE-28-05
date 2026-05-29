using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public class Animais
    {
        // ==========================
        // INTERFACE
        // ==========================
        public interface IComportamento
        {
            void Comer();
            void Dormir();
        }

        // ==========================
        // CLASSE ABSTRATA
        // ==========================
        public abstract class Animal
        {
            public string Nome { get; set; }
            public int Idade { get; set; }

            public Animal(string nome, int idade)
            {
                Nome = nome;
                Idade = idade;
            }

            public abstract void EmitirSom();
        }

        // ==========================
        // CACHORRO
        // ==========================
        public class Cachorro : Animal, IComportamento
        {
            public Cachorro(string nome, int idade)
                : base(nome, idade)
            {
            }

            public override void EmitirSom()
            {
                Console.WriteLine($"{Nome}: Au Au!");
            }

            public void Comer()
            {
                Console.WriteLine($"{Nome} está comendo ração.");
            }

            public void Dormir()
            {
                Console.WriteLine($"{Nome} está dormindo.");
            }
        }

        // ==========================
        // GATO
        // ==========================
        public class Gato : Animal, IComportamento
        {
            public Gato(string nome, int idade)
                : base(nome, idade)
            {
            }

            public override void EmitirSom()
            {
                Console.WriteLine($"{Nome}: Miau!");
            }

            public void Comer()
            {
                Console.WriteLine($"{Nome} está comendo peixe.");
            }

            public void Dormir()
            {
                Console.WriteLine($"{Nome} está dormindo.");
            }
        }

        // ==========================
        // VACA
        // ==========================
        public class Vaca : Animal, IComportamento
        {
            public Vaca(string nome, int idade)
                : base(nome, idade)
            {
            }

            public override void EmitirSom()
            {
                Console.WriteLine($"{Nome}: Muuuuu!");
            }

            public void Comer()
            {
                Console.WriteLine($"{Nome} está comendo capim.");
            }

            public void Dormir()
            {
                Console.WriteLine($"{Nome} está dormindo.");
            }
        }
    }
}
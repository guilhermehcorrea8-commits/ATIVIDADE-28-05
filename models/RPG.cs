using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public class RPG
    {
        // ==========================
        // INTERFACE
        // ==========================
        public interface IHabilidadeEspecial
        {
            void UsarHabilidade();
        }

        // ==========================
        // CLASSE ABSTRATA
        // ==========================
        public abstract class Personagem
        {
            public string Nome { get; set; }
            public int Vida { get; set; }
            public int Ataque { get; set; }

            public Personagem(
                string nome,
                int vida,
                int ataque)
            {
                Nome = nome;
                Vida = vida;
                Ataque = ataque;
            }

            public abstract int Atacar();
        }

        // ==========================
        // GUERREIRO
        // ==========================
        public class Guerreiro :
            Personagem,
            IHabilidadeEspecial
        {
            public Guerreiro(
                string nome,
                int vida,
                int ataque)
                : base(nome, vida, ataque)
            {
            }

            public override int Atacar()
            {
                Console.WriteLine(
                    $"{Nome} atacou com espada!");

                return Ataque;
            }

            public void UsarHabilidade()
            {
                Console.WriteLine(
                    $"{Nome} usou golpe pesado!");
            }
        }

        // ==========================
        // MAGO
        // ==========================
        public class Mago :
            Personagem,
            IHabilidadeEspecial
        {
            public Mago(
                string nome,
                int vida,
                int ataque)
                : base(nome, vida, ataque)
            {
            }

            public override int Atacar()
            {
                Console.WriteLine(
                    $"{Nome} lançou magia!");

                return Ataque;
            }

            public void UsarHabilidade()
            {
                Console.WriteLine(
                    $"{Nome} usou bola de fogo!");
            }
        }

        // ==========================
        // ARQUEIRO
        // ==========================
        public class Arqueiro :
            Personagem,
            IHabilidadeEspecial
        {
            public Arqueiro(
                string nome,
                int vida,
                int ataque)
                : base(nome, vida, ataque)
            {
            }

            public override int Atacar()
            {
                Console.WriteLine(
                    $"{Nome} disparou flecha!");

                return Ataque;
            }

            public void UsarHabilidade()
            {
                Console.WriteLine(
                    $"{Nome} usou chuva de flechas!");
            }
        }
    }
}
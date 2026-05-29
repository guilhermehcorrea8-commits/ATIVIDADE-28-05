using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public class Notificacoes
    {
        // ==========================
        // INTERFACE
        // ==========================
        public interface INotificacao
        {
            void EnviarMensagem(string mensagem);
        }

        // ==========================
        // CLASSE ABSTRATA
        // ==========================
        public abstract class Usuario
        {
            public string Nome { get; set; }
            public string Telefone { get; set; }

            public Usuario(string nome, string telefone)
            {
                Nome = nome;
                Telefone = telefone;
            }

            public abstract void ExibirDados();
        }

        // ==========================
        // USUÁRIO PADRÃO
        // ==========================
        public class UsuarioSistema : Usuario
        {
            public UsuarioSistema(
                string nome,
                string telefone)
                : base(nome, telefone)
            {
            }

            public override void ExibirDados()
            {
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Telefone: {Telefone}");
            }
        }

        // ==========================
        // EMAIL
        // ==========================
        public class Email : INotificacao
        {
            public void EnviarMensagem(
                string mensagem)
            {
                Console.WriteLine(
                    $"Email enviado: {mensagem}");
            }
        }

        // ==========================
        // SMS
        // ==========================
        public class SMS : INotificacao
        {
            public void EnviarMensagem(
                string mensagem)
            {
                Console.WriteLine(
                    $"SMS enviado: {mensagem}");
            }
        }

        // ==========================
        // WHATSAPP
        // ==========================
        public class WhatsApp : INotificacao
        {
            public void EnviarMensagem(
                string mensagem)
            {
                Console.WriteLine(
                    $"WhatsApp enviado: {mensagem}");
            }
        }
    }
}
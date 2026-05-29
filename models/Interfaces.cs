using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public class Interfaces
    {
        // ==========================
        // VEÍCULOS
        // ==========================
        public interface IBuzina
        {
            void Buzinar();
        }

        // ==========================
        // FUNCIONÁRIOS
        // ==========================
        public interface IRelatorio
        {
            void ExibirRelatorio();
        }

        // ==========================
        // PAGAMENTOS
        // ==========================
        public interface IPagamento
        {
            void Pagar(double valor);
        }

        // ==========================
        // LOGIN
        // ==========================
        public interface IAutenticacao
        {
            bool Login(string usuario, string senha);
        }

        // ==========================
        // ANIMAIS
        // ==========================
        public interface IComportamento
        {
            void Comer();
            void Dormir();
        }

        // ==========================
        // FORMAS
        // ==========================
        public interface IDesenho
        {
            void Desenhar();
        }

        // ==========================
        // NOTIFICAÇÃO
        // ==========================
        public interface INotificacao
        {
            void EnviarMensagem(string mensagem);
        }

        // ==========================
        // RPG
        // ==========================
        public interface IHabilidadeEspecial
        {
            void UsarHabilidade();
        }

        // ==========================
        // BANCO
        // ==========================
        public interface ITransferencia
        {
            void Transferir(
                Conta destino,
                double valor);
        }
    }
}
using System;

namespace aula_28._05.models
{
    public abstract class Smartphone
    {
        // Propriedades
        public string Numero { get; set; }
        public string Modelo { get; private set; }
        public string IMEI { get; private set; }
        public int Memoria { get; private set; }

        // Construtor
        public Smartphone(
            string numero,
            string modelo,
            string imei,
            int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos comuns
        public void Ligar()
        {
            Console.WriteLine($"Ligando para o número: {Numero}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo uma ligação no número: {Numero}");
        }

        // Método abstrato
        public abstract void InstalarAplicativo(string nome);
    }
}
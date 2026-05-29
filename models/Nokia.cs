using System;

namespace aula_28._05.models
{
    public class Nokia : Smartphone
    {
        public Nokia(
            string numero,
            string modelo,
            string imei,
            int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine(
                $"Instalando o aplicativo {nome} pela loja da Nokia..."
            );
        }
    }
}
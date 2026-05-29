using aula_28._05.models;
using static aula_28._05.models.Animais;
using static aula_28._05.models.Banco;
using static aula_28._05.models.Carro;
using static aula_28._05.models.Formas;
using static aula_28._05.models.Interfaces;
using static aula_28._05.models.Login;
using static aula_28._05.models.MiniUber;
using static aula_28._05.models.Notificacoes;
using static aula_28._05.models.Pagamentos;
using static aula_28._05.models.Plugins;
using static aula_28._05.models.RPG;

//============================================================//
// Atividade 1 //
//============================================================//

Aluno aluno = new Aluno
{
    Nome = "Guilherme",
    Idade = 17,
    Nota = 9.5
};

Professor professor = new Professor
{
    Nome = "Carlos",
    Idade = 40,
    Salario = 5500
};

aluno.Apresentar();
professor.Apresentar();

Calculadora calc = new Calculadora();

Console.WriteLine(calc.Somar(10, 5));
Console.WriteLine(calc.Dividir(20, 2));

Iphone iphone = new Iphone(
    "999999999",
    "iPhone 15",
    "123456",
    256
);

iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Corrente conta = new Corrente();

conta.Creditar(1000);
conta.ExibirSaldo();

//=============================
// DESAFIO 2
//=============================

int maior = 0;
int posicao = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Entre Com o {0 + i}º Número");
    int numero = int.Parse(Console.ReadLine()!);
    if (numero > maior)
    {
        maior = numero;
        posicao = i;
    }
}

Console.WriteLine(maior);
Console.WriteLine(posicao);

//=============================
// DESAFIO 3
//=============================

Console.WriteLine("Digite a 1ª Nota");
double A = double.Parse(Console.ReadLine()!);
Console.WriteLine("Digite a 2ª Nota");
double B = double.Parse(Console.ReadLine()!);
Console.WriteLine("Digite a 3ª Nota");
double C = double.Parse(Console.ReadLine()!);

double media = ((A * 2) + (B * 3) + (C * 5)) / 10;

Console.WriteLine($"MEDIA = {media}");

//=============================
// DESAFIO 4
//=============================

int N = int.Parse(Console.ReadLine()!);

for (int i = 0; i < N; i++)
{
    string[] valores = Console.ReadLine()!.Split();

    Console.WriteLine("Digite o 1º Número");
    double X = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Digite o 2º Número");
    double Y = double.Parse(Console.ReadLine()!);

    if (Y == 0)
    {
        Console.WriteLine("divisao impossivel");
    }
    else
    {
        double resultado = X / Y;
        Console.WriteLine($"R: {resultado}");
    }
}


//============================================================//
// Atividade 2
//============================================================//

// =====================================
// 1 - VEÍCULOS
// =====================================
Console.WriteLine("===== VEÍCULOS =====");

Carro carro =
    new Carro("Toyota", "Corolla");

Moto moto =
    new Moto("Honda", "CB500");

carro.Acelerar();
carro.Acelerar();
carro.Frear();
carro.Buzinar();

Console.WriteLine(
    $"Carro: {carro.Marca} " +
    $"{carro.Modelo} | " +
    $"Velocidade: {carro.VelocidadeAtual}"
);

Console.WriteLine();

moto.Acelerar();
moto.Acelerar();
moto.Frear();
moto.Buzinar();

Console.WriteLine(
    $"Moto: {moto.Marca} " +
    $"{moto.Modelo} | " +
    $"Velocidade: {moto.VelocidadeAtual}"
);

Console.WriteLine();


// =====================================
// 2 - FUNCIONÁRIOS
// =====================================
Console.WriteLine(
    "===== FUNCIONÁRIOS =====");

List<IRelatorio> funcionarios =
new List<IRelatorio>()
{
    new Gerente("Carlos", 10000),
    new Desenvolvedor("Ana", 6000),
    new Estagiario("Pedro", 2000)
};

foreach (var funcionario in funcionarios)
{
    funcionario.ExibirRelatorio();
    Console.WriteLine();
}


// =====================================
// 3 - PAGAMENTOS
// =====================================
Console.WriteLine(
    "===== PAGAMENTOS =====");

PedidoOnline pedido1 =
    new PedidoOnline(1, 250);

PedidoLoja pedido2 =
    new PedidoLoja(2, 180);

IPagamento pix =
    (IPagamento)new Pix();

IPagamento cartao =
    (IPagamento)new CartaoCredito();

pix.Pagar(pedido1.ValorTotal);
pedido1.FinalizarPedido();

Console.WriteLine();

cartao.Pagar(pedido2.ValorTotal);
pedido2.FinalizarPedido();

Console.WriteLine();


// =====================================
// 4 - ANIMAIS
// =====================================
Console.WriteLine(
    "===== ANIMAIS =====");

List<Animal> animais =
new List<Animal>()
{
    new Cachorro("Rex", 5),
    new Gato("Mingau", 2),
    new Vaca("Mimosa", 7)
};

foreach (Animal animal in animais)
{
    animal.EmitirSom();

    Animais.IComportamento comportamento =
        (Animais.IComportamento)animal;

    comportamento.Comer();
    comportamento.Dormir();

    Console.WriteLine();
}


// =====================================
// 5 - LOGIN
// =====================================
Console.WriteLine(
    "===== LOGIN =====");

Admin admin =
    new Admin(
        "Carlos",
        "admin@email.com"
    );

UsuarioComum usuario =
    new UsuarioComum(
        "Pedro",
        "user@email.com"
    );

if (admin.Login("admin", "123"))
{
    Console.WriteLine(
        "Login Admin realizado!"
    );

    admin.ExibirPermissao();
}

Console.WriteLine();

if (usuario.Login("user", "123"))
{
    Console.WriteLine(
        "Login Usuário realizado!"
    );

    usuario.ExibirPermissao();
}

Console.WriteLine();


// =====================================
// 6 - FORMAS GEOMÉTRICAS
// =====================================
Console.WriteLine(
    "===== FORMAS GEOMÉTRICAS =====");

List<Forma> formas =
new List<Forma>()
{
    new Quadrado(5),
    new Retangulo(10, 5),
    new Circulo(3)
};

double areaTotal = 0;
Forma maiorForma = formas[0];

foreach (Forma forma in formas)
{
    double area =
        forma.CalcularArea();

    Console.WriteLine(
        $"Área: {area:F2}");

    areaTotal += area;

    if (area >
        maiorForma.CalcularArea())
    {
        maiorForma = forma;
    }
}

Console.WriteLine();

Console.WriteLine(
    $"Área total: {areaTotal:F2}");

Console.WriteLine(
    $"Maior área: " +
    $"{maiorForma.CalcularArea():F2}"
);


// =====================================
// 7 - NOTIFICAÇÕES
// =====================================
Console.WriteLine(
    "===== NOTIFICAÇÕES =====");

List<UsuarioSistema> usuarios =
new List<UsuarioSistema>()
{
    new UsuarioSistema(
        "Carlos",
        "54999999999"),

    new UsuarioSistema(
        "Ana",
        "54988888888")
};

Interfaces.INotificacao whatsapp =
    (Interfaces.INotificacao)new WhatsApp();

foreach (var usuarioSistema
    in usuarios)
{
    usuarioSistema.ExibirDados();

    whatsapp.EnviarMensagem(
        "Bem-vindo ao sistema!"
    );

    Console.WriteLine();
}


// =====================================
// 8 - RPG
// =====================================
Console.WriteLine(
    "===== RPG =====");

Personagem guerreiro =
    new Guerreiro(
        "Thor",
        100,
        20
    );

Personagem mago =
    new Mago(
        "Merlin",
        80,
        25
    );

int dano =
    guerreiro.Atacar();

mago.Vida -= dano;

Console.WriteLine(
    $"Vida restante de " +
    $"{mago.Nome}: {mago.Vida}"
);

((Interfaces.IHabilidadeEspecial)
guerreiro).UsarHabilidade();

Console.WriteLine();


// =====================================
// 9 - BANCO
// =====================================
Console.WriteLine(
    "===== SISTEMA BANCÁRIO =====");

ContaCorrente conta1 =
    new ContaCorrente(
        1,
        1000
    );

ContaPoupanca conta2 =
    new ContaPoupanca(
        2,
        500
    );

conta1.Depositar(200);
conta1.Sacar(150);

conta1.Transferir(
    conta2,
    300
);

Console.WriteLine();

conta1.MostrarExtrato();

Console.WriteLine();

conta2.MostrarExtrato();

Console.WriteLine(
    $"\nTaxa Corrente: " +
    $"R$ {conta1.CalcularTaxa():F2}"
);

Console.WriteLine(
    $"Taxa Poupança: " +
    $"R$ {conta2.CalcularTaxa():F2}"
);

Console.WriteLine(
    "\nFim do programa!"
);
// =====================================
// 10 - MINI UBER
// =====================================
Console.WriteLine(
    "===== MINI UBER =====");

List<VeiculoAplicativo> veiculos =
new List<VeiculoAplicativo>()
{
    new CarroUber(
        "ABC-1234",
        "Corolla"),

    new MotoUber(
        "XYZ-9999",
        "Honda CG")
};

double totalArrecadado = 0;
VeiculoAplicativo maisCorridas =
    veiculos[0];

int opcao;

do
{
    Console.WriteLine();
    Console.WriteLine(
        "1 - Fazer Corrida");

    Console.WriteLine(
        "2 - Mostrar Total");

    Console.WriteLine(
        "3 - Veículo com mais corridas");

    Console.WriteLine(
        "0 - Sair");

    opcao =
        int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:

            Console.WriteLine(
                "Escolha veículo:");

            for (int i = 0;
                i < veiculos.Count;
                i++)
            {
                Console.WriteLine(
                    $"{i} - {veiculos[i].Modelo}");
            }

            int indice =
                int.Parse(
                    Console.ReadLine()!);

            Console.WriteLine(
                "Km da corrida:");

            double km =
                double.Parse(
                    Console.ReadLine()!);

            double valor =
                veiculos[indice]
                .CalcularCorrida(km);

            totalArrecadado +=
                valor;

            Console.WriteLine(
                $"Corrida: R$ {valor:F2}");

            if (veiculos[indice]
                .QuantidadeCorridas >
                maisCorridas
                .QuantidadeCorridas)
            {
                maisCorridas =
                    veiculos[indice];
            }

            break;

        case 2:

            Console.WriteLine(
                $"Total arrecadado: R$ {totalArrecadado:F2}");

            break;

        case 3:

            Console.WriteLine(
                $"Veículo com mais corridas: {maisCorridas.Modelo}");

            Console.WriteLine(
                $"Corridas: {maisCorridas.QuantidadeCorridas}");

            break;
    }

} while (opcao != 0);


// =====================================
// 11 - SISTEMA DE PLUGINS
// =====================================
Console.WriteLine();
Console.WriteLine(
    "===== SISTEMA DE PLUGINS =====");

Sistema sistema =
    new Sistema();

sistema.CarregarPlugin(
    new PluginAudio());

sistema.CarregarPlugin(
    new PluginVideo());

sistema.CarregarPlugin(
    new PluginSeguranca());

Console.WriteLine(
    "\nExecutando Plugins:");

sistema.ExecutarTodos();

Console.WriteLine(
    "\nEncerrando Plugins:");

sistema.EncerrarTodos();
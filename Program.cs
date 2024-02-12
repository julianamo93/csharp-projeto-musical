// Screen Sound
string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound!";
List<string> ListaDasBandas = new List<string> {"BTS", "TWICE", "Stray Kidz"};

void ExibirLogo()
{ 
    Console.WriteLine(@"
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝

░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\n1. Registrar banda");
    Console.WriteLine("2. Mostrar Todas as Bandas");
    Console.WriteLine("3. Avaliar Banda");
    Console.WriteLine("4. Exibir média da Banda");
    Console.WriteLine("5. Sair");

    Console.Write("\nEscolha sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
  
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 5: Console.WriteLine("Encerrando o programa...");
            break;
        default: Console.WriteLine("Opção inválida!");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("******************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("******************");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    ListaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();    
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("*************************************");
    Console.WriteLine("Exibindo todas as Bandas Registradas");
    Console.WriteLine("*************************************\n");

    //for (int i=0; i < ListaDasBandas.Count; i++)
    //{
        //Console.WriteLine($"Banda: {ListaDasBandas[i]}");
    //}

    foreach (string banda in ListaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para retornar ao Menu Principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirLogo();
ExibirOpcoesDoMenu();
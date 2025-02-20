//Screen sound
//Escrever uma variavel string
string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";
/*List<string> listasDasBandas = new List<string>();  //cria uma lista de string vazia para armazenar algo que o usuario digitar*/

//ou a lista ja pode ser pré criada
List<string> listasDasBandas = new List<string> { "U2", "The Beatle", "Nirvana","Calipso"};

//Funções
//void é uma função sem retorno, usa a convenção de PascalCase
void ExibirLogo()
{
    Console.WriteLine(@"
    
▒█▀▀▀█ █▀▀ █▀▀█ █▀▀ █▀▀ █▀▀▄ 　 █▀▀ █▀▀█ █░░█ █▀▀▄ █▀▀▄ 
░▀▀▀▄▄ █░░ █▄▄▀ █▀▀ █▀▀ █░░█ 　 ▀▀█ █░░█ █░░█ █░░█ █░░█ 
▒█▄▄▄█ ▀▀▀ ▀░▀▀ ▀▀▀ ▀▀▀ ▀░░▀ 　 ▀▀▀ ▀▀▀▀ ░▀▀▀ ▀░░▀ ▀▀▀░
");//o uso do @ no texto é para trazer ao código como o texto será inserido @ = "verbatim literal"
    Console.WriteLine(mensagemDeBoasVindas);
}


void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");//"\n" dá uma quebra de linha 
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");//tira o line para não pular para a linha debaixo
    string opcaoEscolhida = Console.ReadLine()!;//usa o .Read ou .ReadLine para ler o que o usuario escreve// usa o"!" para não dar valor null
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);//Converte uma string para numero inteiro (int)

    /*if(opcaoEscolhidaNumerica == 1)//"==" é o termo usado de consição "se"
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida + "!");
    }else if (opcaoEscolhidaNumerica == 2)
        {
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida + "!");
        }
    else if (opcaoEscolhidaNumerica == 3)
        {
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida + "!");
        }
    else if (opcaoEscolhidaNumerica == 4)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida + "!");
    }
    else if (opcaoEscolhidaNumerica == -1)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida + "!");
    }*/

// ou pode fazer assim:
switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break; 
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você escolheu a opção" + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção" + opcaoEscolhidaNumerica);
            break;
        case -1: Console.WriteLine("Bye,Bye:)");    
            break;
        default: Console.WriteLine("Opção inválida");
            break;


    }
}
void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listasDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");//interpolação de string (coloca coisas no meio da string)
    Thread.Sleep(2000);//espera aberto a aplicação em milisegundos depois fecha
    Console.Clear();//limpa o console
    ExibirOpcoesDoMenu();

}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("Exibindo todas as bandas registradas\n");
    /*for (int i = 0; i < listasDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listasDasBandas[i]}");
    }*/

    //ou faça assim:
    foreach(string banda in listasDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao nenu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();
//Screen sound
//Escrever uma variavel string
string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";
/*List<string> listasDasBandas = new List<string>();  //cria uma lista de string vazia para armazenar algo que o usuario digitar*/

//ou a lista ja pode ser pré criada
//List<string> listasDasBandas = new List<string> { "U2", "The Beatle", "Nirvana","Calipso"};

// ou ,melhor, nesse caso podemos criar um dicionário, que é uma estrutura que tem chave(nome da banda) e valor(nota) 
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("U2", new List<int> { 5, 10, 2, 9 });
bandasRegistradas.Add("The Beatle", new List<int> ());

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
        case 3: AvaliarUmaBanda();
            break;
        case 4:MediaDaBanda();  
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
    ExibirTituloDaOpcao("Registro das Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");//interpolação de string (coloca coisas no meio da string)
    Thread.Sleep(2000);//espera aberto a aplicação em milisegundos depois fecha
    Console.Clear();//limpa o console
    ExibirOpcoesDoMenu();

}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    /*for (int i = 0; i < listasDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listasDasBandas[i]}");
    }*/

    //ou faça assim:
    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao nenu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteristicos =string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n" );
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliando uma banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Digite a nota que a banda {nomeDaBanda} merece! ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A banda {nomeDaBanda} foi avaliada com sucesso");
        Thread.Sleep(4000);
        Console.Clear() ;
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    
    ExibirOpcoesDoMenu();
}
void MediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Calculando a média de uma banda");
    Console.Write("Digite o nome da banda que deseja calcular a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notas = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média das notas da banda {nomeDaBanda} é: {notas.Average()}");//Average() é um método que calcula a média,mais fácil
        //ou pode fazer assim:(mais complexo)
        /*double somaDasNotas = 0;
        foreach (int nota in notas)
        {
            somaDasNotas += nota;
        }
        double media = somaDasNotas / notas.Count;
        Console.WriteLine($"A média da banda {nomeDaBanda} é {media}");*/
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();
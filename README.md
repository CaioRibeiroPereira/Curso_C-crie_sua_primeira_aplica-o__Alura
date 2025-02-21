EXPLICAÇÃO CÓDIGO C# DO CURSO "C#:CRIANDO SUA PRIMEIRA APLICAÇÃO"

O código em `Program.cs` é um programa de console em C# que gerencia uma lista de bandas e permite ao usuário registrar, listar, avaliar e calcular a média das avaliações das bandas.É um programa simples de iniciação na aprendizagem da linguagem C#. Aqui está uma explicação detalhada:

1. **Mensagem de Boas Vindas**:
   ```csharp
   string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";
   ```

2. **Dicionário para registrar bandas e suas avaliações**:
   ```csharp
   Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
   bandasRegistradas.Add("U2", new List<int> { 5, 10, 2, 9 });
   bandasRegistradas.Add("The Beatle", new List<int> ());
   ```

3. **Função que exibe a logo**:
   ```csharp
   void ExibirLogo()
   {
       Console.WriteLine(@"
       ▒█▀▀▀█ █▀▀ █▀▀█ █▀▀ █▀▀ █▀▀▄ 　 █▀▀ █▀▀█ █░░█ █▀▀▄ █▀▀▄ 
       ░▀▀▀▄▄ █░░ █▄▄▀ █▀▀ █▀▀ █░░█ 　 ▀▀█ █░░█ █░░█ █░░█ █░░█ 
       ▒█▄▄▄█ ▀▀▀ ▀░▀▀ ▀▀▀ ▀▀▀ ▀░░▀ 　 ▀▀▀ ▀▀▀▀ ░▀▀▀ ▀░░▀ ▀▀▀░
       ");
       Console.WriteLine(mensagemDeBoasVindas);
   }
   ```

4. **Função que exibe o menu de opções**:
   ```csharp
   void ExibirOpcoesDoMenu()
   {
       ExibirLogo();
       Console.WriteLine("\nDigite 1 para registrar uma banda");
       Console.WriteLine("Digite 2 para mostrar todas as bandas");
       Console.WriteLine("Digite 3 para avaliar uma banda");
       Console.WriteLine("Digite 4 para exibir a média de uma banda");
       Console.WriteLine("Digite -1 para sair");
       Console.Write("\nDigite a sua opção: ");
       string opcaoEscolhida = Console.ReadLine()!;
       int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

       switch (opcaoEscolhidaNumerica)
       {
           case 1: RegistrarBanda(); break;
           case 2: MostrarBandasRegistradas(); break;
           case 3: AvaliarUmaBanda(); break;
           case 4: MediaDaBanda(); break;
           case -1: Console.WriteLine("Bye,Bye:)"); break;
           default: Console.WriteLine("Opção inválida"); break;
       }
   }
   ```

5. **Função para registrar uma banda**:
   ```csharp
   void RegistrarBanda()
   {
       Console.Clear();
       ExibirTituloDaOpcao("Registro das Bandas");
       Console.Write("Digite o nome da banda que deseja registrar: ");
       string nomeDaBanda = Console.ReadLine()!;
       bandasRegistradas.Add(nomeDaBanda, new List<int>());
       Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
       Thread.Sleep(2000);
       Console.Clear();
       ExibirOpcoesDoMenu();
   }
   ```

6. **Função para mostrar todas as bandas registradas**:
   ```csharp
   void MostrarBandasRegistradas()
   {
       Console.Clear();
       ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
       foreach(string banda in bandasRegistradas.Keys)
       {
           Console.WriteLine($"Banda: {banda}");
       }
       Console.WriteLine("\nDigite qualquer tecla para voltar ao menu");
       Console.ReadKey();
       Console.Clear();
       ExibirOpcoesDoMenu();
   }
   ```

7. **Função para exibir títulos das opções**:
   ```csharp
   void ExibirTituloDaOpcao(string titulo)
   {
       int quantidadeDeLetras = titulo.Length;
       string asteristicos = string.Empty.PadLeft(quantidadeDeLetras, '*');
       Console.WriteLine(asteristicos);
       Console.WriteLine(titulo);
       Console.WriteLine(asteristicos + "\n" );
   }
   ```

8. **Função para avaliar uma banda**:
   ```csharp
   void AvaliarUmaBanda()
   {
       Console.Clear();
       ExibirTituloDaOpcao("Avaliando uma banda");
       Console.Write("Digite o nome da banda que deseja avaliar: ");
       string nomeDaBanda = Console.ReadLine()!;
       if (bandasRegistradas.ContainsKey(nomeDaBanda))
       {
           Console.Write($"Digite a nota que a banda {nomeDaBanda} merece: ");
           int nota = int.Parse(Console.ReadLine()!);
           bandasRegistradas[nomeDaBanda].Add(nota);
           Console.WriteLine($"A banda {nomeDaBanda} foi avaliada com sucesso");
           Thread.Sleep(4000);
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
   ```

9. **Função para calcular a média das notas de uma banda**:
   ```csharp
   void MediaDaBanda()
   {
       Console.Clear();
       ExibirTituloDaOpcao("Calculando a média de uma banda");
       Console.Write("Digite o nome da banda que deseja calcular a média: ");
       string nomeDaBanda = Console.ReadLine()!;
       if (bandasRegistradas.ContainsKey(nomeDaBanda))
       {
           List<int> notas = bandasRegistradas[nomeDaBanda];
           Console.WriteLine($"\nA média das notas da banda {nomeDaBanda} é: {notas.Average()}");
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
   ```

10. **Início do programa**:
    ```csharp
    ExibirOpcoesDoMenu();
    ```

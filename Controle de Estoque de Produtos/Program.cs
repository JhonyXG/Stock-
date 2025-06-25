
 Dictionary<string, List<int>> produtos = new Dictionary<string, List<int>>();


        ExibirMenu();
    
     void adProduto()

    {
        Console.Clear();
        Console.WriteLine("Escreva qual produto deseja adicionar");
        string produto = Console.ReadLine();

        produtos.Add(produto, new List<int>());
        Console.WriteLine("\nAgora digite a quantidade: ");
        int quantia = int.Parse(Console.ReadLine());
        produtos[produto].Add(quantia);


        Console.WriteLine($"o produto {produto} com {quantia} de unidades foi adicionado com sucesso!");
        Thread.Sleep(4000);

       Console.Clear();


    ExibirMenu();
    }
     void sair()
    {
        Console.Clear();
        Console.WriteLine("pressione qualquer tecla para sair");
        Console.ReadKey();


    }

     void ExibirMenu()
    {

    Console.WriteLine(@$"Bem Vindo ao:
░██████╗████████╗░█████╗░░█████╗░██╗░░██╗
██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██║░██╔╝
╚█████╗░░░░██║░░░██║░░██║██║░░╚═╝█████═╝░
░╚═══██╗░░░██║░░░██║░░██║██║░░██╗██╔═██╗░
██████╔╝░░░██║░░░╚█████╔╝╚█████╔╝██║░╚██╗
╚═════╝░░░░╚═╝░░░░╚════╝░░╚════╝░╚═╝░░╚═╝         ");
    Thread.Sleep(2000);


    Console.WriteLine("Carregando aplicação...");
            Thread.Sleep(2000);

    Console.Clear();
       
        Console.WriteLine($"Digite uma opção:");
        Console.WriteLine("\nDigite 1 para ver o estoque de um produto:");
        Console.WriteLine("Digite 2 para adicionar um produto ");
        Console.WriteLine("Digite 3 para sair ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {

            case 1:
                verEstoque();
                break;

            case 2:
                adProduto();
                break;

            case 3:
                sair();
                break;



        }
        void verEstoque()
        {
            Console.Clear();
            Console.WriteLine("carregando estoque...");
            Thread.Sleep(4000);
            if (produtos.Count == 0)
            {
                Console.WriteLine("nao ha produtos no estoque");
                Thread.Sleep(1000);
                Console.WriteLine("tenha um otimo dia!");
                Thread.Sleep(2000);
                Console.Clear();
                ExibirMenu();
            }
            else
            {
                foreach (var produto in produtos)
                {
                    Console.WriteLine($"Temos: {produto.Key} a quantia de: {string.Join(", ", produto.Value)} de unidades");
                    Thread.Sleep(2000);
                    Console.Clear();
                     ExibirMenu();
                }
            }


        }
    }
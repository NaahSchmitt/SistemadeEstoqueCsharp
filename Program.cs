namespace C__PTISenac;

class Program
{
    static void Main(string[] args)
    {
        Estoque estoque = new Estoque();

        while (true)
        {
            Console.WriteLine("\nCONTROLE DE ESTOQUE - FLORICULTURA");
            Console.WriteLine("[1] Novo");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produtos");
            Console.WriteLine("[4] Entrada Estoque");
            Console.WriteLine("[5] Saída Estoque");
            Console.WriteLine("[0] Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Informe o tipo (Ex: Rosa, Orquídea, Girassol): ");
                    string nome = Console.ReadLine();

                    Console.Write("Informe o preço: ");
                    decimal preco = decimal.Parse(Console.ReadLine());

                    Console.Write("Informe a cor: ");
                    string cor = Console.ReadLine();
                    
                    Console.Write("Informe a origem (Ex: Nacional, Importada): ");
                    string origem = Console.ReadLine();

                    Produto novoProduto = new Produto(nome, preco, cor, origem);
                    estoque.AdicionarProduto(novoProduto);
                    break;

                case "2":
                    estoque.ListarProdutos();
                    break;

                case "3":
                    estoque.ListarProdutos();
                    Console.Write("Informe a posição do produto a ser removido: ");
                    int indiceRemover = int.Parse(Console.ReadLine()) - 1;
                    estoque.RemoverProduto(indiceRemover);
                    break;

                case "4":
                    estoque.ListarProdutos();
                    Console.Write("Informe a posição do produto: ");
                    int indiceEntrada = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Informe a quantidade de Entrada: ");
                    int quantidadeEntrada = int.Parse(Console.ReadLine());
                    estoque.EntradaEstoque(indiceEntrada, quantidadeEntrada);
                    break;

                case "5":
                    estoque.ListarProdutos();
                    Console.Write("Informe a posição do produto: ");
                    int indiceSaida = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Informe a quantidade de Saída: ");
                    int quantidadeSaida = int.Parse(Console.ReadLine());
                    estoque.SaidaEstoque(indiceSaida, quantidadeSaida);
                    break;

                case "0":
                    Console.WriteLine("Saindo do sistema...");
                    return;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}


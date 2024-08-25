using System;
using System.Collections.Generic;

public class Estoque
{
    private List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
        Console.WriteLine("Produto adicionado!");
    }

    public void ListarProdutos()
    {
        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
        }
        else
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {produtos[i]}");
            }
        }
    }

    public void RemoverProduto(int indice)
    {
        if (indice >= 0 && indice < produtos.Count)
        {
            Produto removido = produtos[indice];
            produtos.RemoveAt(indice);
            Console.WriteLine($"Produto '{removido.Nome}' removido!");
        }
        else
        {
            Console.WriteLine("Índice inválido!");
        }
    }

    public void EntradaEstoque(int indice, int quantidade)
    {
        if (indice >= 0 && indice < produtos.Count)
        {
            produtos[indice].AdicionarEstoque(quantidade);
            Console.WriteLine($"Entrada de {quantidade} unidades do produto '{produtos[indice].Nome}' realizada!");
        }
        else
        {
            Console.WriteLine("Índice inválido!");
        }
    }

    public void SaidaEstoque(int indice, int quantidade)
    {
        if (indice >= 0 && indice < produtos.Count)
        {
            try
            {
                produtos[indice].RemoverEstoque(quantidade);
                Console.WriteLine($"Saída de {quantidade} unidades do produto '{produtos[indice].Nome}' realizada!");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        else
        {
            Console.WriteLine("Índice inválido!");
        }
    }
}

using System;

public class Produto
{
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public string Cor { get; private set; }
    public int QuantidadeEstoque { get; private set; }
    public string Origem { get; private set; }

    public Produto(string nome, decimal preco, string cor, string origem)
    {
        Nome = nome;
        Preco = preco;
        Cor = cor;
        Origem = origem;
        QuantidadeEstoque = 0;
    }

    public void AdicionarEstoque(int quantidade)
    {
        QuantidadeEstoque += quantidade;
    }

    public void RemoverEstoque(int quantidade)
    {
        if (QuantidadeEstoque >= quantidade)
        {
            QuantidadeEstoque -= quantidade;
        }
        else
        {
            throw new InvalidOperationException("Quantidade em estoque insuficiente!");
        }
    }

    public override string ToString()
    {
        return $"{Nome} (Cor: {Cor}, Origem: {Origem}, {Preco:C}) - {QuantidadeEstoque} no estoque";
    }
}

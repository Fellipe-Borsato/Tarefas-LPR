using System;
struct Produto
{
    public string Nome;
    public int Codigo;
    public float Preco;
    public int Quantidade;
}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Inserir dados do produto {i + 1}:");

            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Codigo: ");
            produtos[i].Codigo = int.Parse(Console.ReadLine());

            Console.Write("Preco: ");
            produtos[i].Preco = float.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        float precoTotal = 0;

        for (int i = 0; i < 3; i++)
        {
            precoTotal += produtos[i].Preco * produtos[i].Quantidade;
        }

        Console.WriteLine($"Valor total em estoque: {valorTotalEstoque}");
    }
}


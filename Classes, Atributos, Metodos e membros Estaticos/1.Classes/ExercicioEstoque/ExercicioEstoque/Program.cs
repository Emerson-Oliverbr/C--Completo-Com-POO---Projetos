using System;
using System.Globalization;

namespace ExercicioEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {produto}");
            Console.WriteLine();

            Console.Write("Digite a quantidade de produtos a serem adicionadas ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            produto.AdicionarProdutosAoEstoque(qtde);
            Console.WriteLine($"Dados do produto atualizado: {produto}");
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a serem removidas do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            produto.RemoverProdutosDoEstoque(qtde);
            Console.WriteLine($"Dados do produto atualizado: {produto}");

            Console.ReadKey();
        }
    }
}


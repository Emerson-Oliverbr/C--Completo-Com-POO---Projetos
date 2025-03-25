using System.Globalization;

namespace ExercicioEstoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutosAoEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutosDoEstoque(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{Nome}, R$ {Preco.ToString("F2",CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: R$ {ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture)}";
        }

    }
}

namespace Lista2_Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoProduto, quantidade;
            string produto;
            decimal preco, valorTotal;

            Console.Write("Digite o Código do Produto: ");
            codigoProduto = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a Quantidade: ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            switch (codigoProduto) 
            {
                case 1:
                    produto = "Cachorro Quente";
                    preco = 10;
                    break;
                case 2:
                    produto= "X-Salada";
                    preco = 15;
                    break;
                case 3:
                    produto = "X-Bacon";
                    preco = 18;
                    break;
                case 4:
                    produto = "Bauru";
                    preco = 12;
                    break;
                case 5:
                    produto = "Refrigerante";
                    preco = 8;
                    break;
                default:
                    produto = "Suco de Laranja";
                    preco = 13;
                    break;
            }

            valorTotal = quantidade * preco;

            Console.WriteLine($"\nProduto: {produto}");
            Console.WriteLine($"Valor Total: R${valorTotal: 0.00}");

        }
    }
}
namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, diferenca;

            Console.WriteLine("Digite número1: ");
            n1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite número2: ");
            n2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite número3: ");
            n3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite número4: ");
            n4 = Convert.ToSingle(Console.ReadLine());

            diferenca = (n1 * n2) - (n3 * n4);

            Console.WriteLine($"Diferença: {diferenca: 0.0}");
        }
    }
}
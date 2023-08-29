namespace Lista01_Vetores_Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int numero;

            Console.WriteLine("Digite o número que você deseja encontrar: ");
            numero = Convert.ToInt32(Console.ReadLine());

                if (Array.IndexOf(vetor, numero) != -1)
                {
                    Console.WriteLine($"O número {numero} está localizado na posição: " + Array.IndexOf(vetor, numero));
                }
                else
                {
                    Console.WriteLine($"O numero {numero} não foi encontrado!");
                }


        }
    }
}
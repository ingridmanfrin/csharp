namespace Lista01_Vetores_Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 2,5,1,3,4,9,7,8,10,6 };
            int numero;

            Console.WriteLine("Digite o número que você deseja encontrar: ");
            numero = Convert.ToInt32(Console.ReadLine());


            for (int indice = 0; indice < 10; indice++)
            {
                if (vetor[indice] == numero)
                {
                    Console.WriteLine($"O número {numero} está localizado na posição: {indice} ");
                }

            }
        }
    }
}
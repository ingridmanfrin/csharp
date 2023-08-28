namespace Lista01_Vetores_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            double soma=0;
            double media = 0;

            for (int indice = 0; indice < 10; indice++)
            {
                Console.Write($"vetor[{indice}] = ");
                vetor[indice] = Convert.ToInt32(Console.ReadLine());
                
                soma = soma + vetor[indice];
            }
            
            media = soma / 10;

            Console.WriteLine();

            Console.WriteLine("\nElementos nos índices ímpares: ");
            for (int indice = 1; indice < 10; indice += 2)
            {
                Console.Write($"{vetor[indice]} ");
            }
           
            Console.WriteLine();

            Console.WriteLine("\nElementos pares: ");
            for (int indice = 0; indice < 10; indice ++)
            {
                if (vetor[indice] % 2 == 0)
                {
                    Console.Write($"{vetor[indice]} ");
                }
            }

            Console.WriteLine();

            Console.WriteLine($"\nSoma: {soma}");
            
            Console.WriteLine($"\nMédia: {media: 0.00}");
        }
    }
}
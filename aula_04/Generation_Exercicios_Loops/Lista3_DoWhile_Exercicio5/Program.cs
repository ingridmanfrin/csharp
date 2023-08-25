namespace Lista3_DoWhile_Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, soma=0;

            do
            {
                Console.WriteLine("\nDigite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero >0)
                {
                    soma = soma + numero;
                }

            } while (numero != 0);

            Console.WriteLine($"\nA soma dos números positivos é: {soma}");
        }
    }
}
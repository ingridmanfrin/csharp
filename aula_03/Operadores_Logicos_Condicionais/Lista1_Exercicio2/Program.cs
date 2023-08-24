namespace Lista1_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0 && numero > 0)
            {
                Console.WriteLine($"O Número {numero} é par e positivo!");
            }
            else if (numero % 2 == 0 && numero < 0)
            {
                Console.WriteLine($"O Número {numero} é par e negativo!");
            }
            else if (numero % 2 != 0 && numero > 0)
            {
                Console.WriteLine($"O Número {numero} é ímpar e positivo!");
            }
            else
            {
                Console.WriteLine($"O Número {numero} é ímpar e negativo!");
            }
        }
    }
}
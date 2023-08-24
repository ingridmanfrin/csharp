namespace Lista1_Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroA, numeroB, numeroC, soma;

            Console.Write("Digite o número A: ");
            numeroA= Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número B: ");
            numeroB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número C: ");
            numeroC = Convert.ToInt32(Console.ReadLine());

            soma = numeroA + numeroB;

            if (soma > numeroC)
            {
                Console.WriteLine($"{numeroA} + {numeroB} = {soma} > {numeroC}");
                Console.WriteLine($"A soma de A + B é Maior do que C");
            }
            else if (soma < numeroC)
            {
                Console.WriteLine($"{numeroA} + {numeroB} = {soma} < {numeroC}");
                Console.WriteLine($"A soma de A + B é Menor do que C");
            }
            else
            {
                Console.WriteLine($"{numeroA} + {numeroB} = {soma} = {numeroC}");
                Console.WriteLine($"A soma de A + B é Igual a C");
            }
        }
    }
}
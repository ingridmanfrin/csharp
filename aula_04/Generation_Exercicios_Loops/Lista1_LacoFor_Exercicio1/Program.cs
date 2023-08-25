namespace Lista1_LacoFor_Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero, segundoNumero;
                
            Console.WriteLine($"Digite o primeiro número do intervalo:");
            primeiroNumero = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine($"Digite o segundo número do intervalo:");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            if (primeiroNumero < segundoNumero)
            {
                Console.WriteLine($"No intervalo entre {primeiroNumero} e {segundoNumero}: ");

                for (int contador = primeiroNumero; contador <= segundoNumero; contador++)
                {
                    if (contador % 5 == 0 && contador % 3 ==0)
                    {
                        Console.WriteLine($"{contador} é múltiplo de 3 e de 5");
                    }
                }
            }
            else
            {
                Console.WriteLine("Intervalo Inválido!");
            }
        }
    }
}
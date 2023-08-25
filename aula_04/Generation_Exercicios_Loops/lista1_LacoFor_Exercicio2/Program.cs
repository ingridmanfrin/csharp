namespace lista1_LacoFor_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDigitado;
            int numerosPares = 0, numerosImpares = 0;

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine($"Digite o {contador}º número: ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());

                if (numeroDigitado % 2 == 0)
                {
                    numerosPares++;
                }
                else 
                {
                    numerosImpares++;
                }
            }

            Console.WriteLine($"\nTotal de números pares: {numerosPares}");
            Console.WriteLine($"\nTotal de números ímpares: {numerosImpares}");
        }
    }
}
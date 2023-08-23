namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, mediaFinal;

            Console.WriteLine("Digite a Nota 1: ");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a Nota 2: ");
            nota2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a Nota 3: ");
            nota3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a Nota 4: ");
            nota4 = Convert.ToSingle(Console.ReadLine());

            mediaFinal = (nota1 + nota2 + nota3 + nota4)/ 4;
            Console.WriteLine($"Média final: {mediaFinal: 0.0}");
        }
    }
}
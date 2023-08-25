namespace Lista2_Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2;
            int codigoOperacao;
            string operacao;

            Console.Write("Digite o 1º número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Operação: ");
            codigoOperacao = Convert.ToInt32(Console.ReadLine());

            switch (codigoOperacao)
            {
                case 1:
                    Console.WriteLine($"\n{numero1: 0.0} + {numero2: 0.0} = {(numero1 + numero2): 0.0}");
                    break;
                case 2:
                    Console.WriteLine($"\n{numero1: 0.0} - {numero2: 0.0} = {(numero1 - numero2): 0.0}");
                    break;
                case 3:
                    Console.WriteLine($"\n{numero1: 0.0} * {numero2: 0.0} = {(numero1 * numero2): 0.0}");
                    break;
                case 4:
                    Console.WriteLine($"\n{numero1: 0.0} / {numero2: 0.0} = {(numero1 / numero2): 0.0}");
                    break;
                default:
                    Console.WriteLine("\nOperação Inválida!");
                    break;
            }
        }
    }
}
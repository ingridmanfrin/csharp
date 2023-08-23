namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono, novoSalario;

            Console.WriteLine("Digite o salário:");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o abono:");
            abono = Convert.ToSingle(Console.ReadLine());

            novoSalario = salario + abono;
            
            Console.WriteLine($"O valor do salário atualizado é: {novoSalario: 0.00} reais."); // com o $ na frente vira uma interpolação

        }
    }
}
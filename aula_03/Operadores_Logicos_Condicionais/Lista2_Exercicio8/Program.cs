using System.Drawing;

namespace Lista2_Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operacao;
            int codigoOperacao;
            float saldo = 1000, valor; 

            Console.Write("Operação: ");
            codigoOperacao = Convert.ToInt32(Console.ReadLine());

            switch (codigoOperacao) 
            {
                case 1:
                    operacao = "Saldo";
                    Console.WriteLine($"\nOperação - {operacao}");
                    Console.WriteLine($"Saldo: R${saldo: 0.00}");
                    break;
                case 2:
                    operacao = "Saque";
                    Console.Write("Valor: ");
                    valor = Convert.ToSingle(Console.ReadLine());
                    
                    if (valor > saldo) 
                    {
                        Console.Write("\nSaldo Insuficiente!\n");
                    }
                    else 
                    {
                        saldo = saldo - valor;

                        Console.WriteLine($"\nOperação - {operacao}");
                        Console.WriteLine($"Novo Saldo: R${saldo: 0.00}");
                    }
                    break;
                case 3:
                    operacao = "Depósito";
                    Console.Write("Valor: ");
                    valor = Convert.ToSingle(Console.ReadLine());

                    saldo = saldo + valor;

                    Console.WriteLine($"\nOperação - {operacao}");
                    Console.WriteLine($"Novo Saldo: R${saldo: 0.00}");
                    break;
                default:
                    Console.WriteLine("\nOperação Inválida!");
                    break;
            }

        }
    }
}
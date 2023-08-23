namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salarioBruto, adicionalNoturno, horasExtras, descontos, salarioLiquido;

            Console.WriteLine("Digite o Salário Bruto: ");
            salarioBruto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o Adicional Noturno: ");
            adicionalNoturno = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o Horas Extras: ");
            horasExtras = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o Desconto: ");
            descontos = Convert.ToSingle(Console.ReadLine());

            salarioLiquido = salarioBruto + adicionalNoturno + (horasExtras * 5) - descontos;

            Console.WriteLine($"Salário Líquido: {salarioLiquido: 0.00}");

        }
    }
}
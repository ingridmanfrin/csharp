using Atividade02_Funcionario.Model;

namespace Atividade02_Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario(1, "Carlos", 43, "Gerente", 30000.00, new DateTime(2022,12,01));
            funcionario1.Visualizar();

            Funcionario funcionario2 = new Funcionario(2, "Maria", 39, "Diretora", 80000.00, new DateTime(2015, 04, 09));
            funcionario2.Visualizar();
        }
    }
}
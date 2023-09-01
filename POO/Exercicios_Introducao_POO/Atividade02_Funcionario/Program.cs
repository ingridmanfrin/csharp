using Atividade02_Funcionario.Model;

namespace Atividade02_Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario(1, "Carlos", 43, "Gerente", 30000.00, new DateTime(2022, 12, 01));
            funcionario1.Visualizar();

            Funcionario funcionario2 = new Funcionario(2, "Maria", 39, "Diretora", 80000.00, new DateTime(2015, 04, 09));
            funcionario2.Visualizar();

            Gerente g1 = new Gerente(1, "Ana", 39, "Gerente", 19000.00, new DateTime(2003, 11, 03), 15);
            g1.Visualizar();

            Gerente g2 = new Gerente(2, "Marcos", 50, "Gerente", 19000.00, new DateTime(2011, 02, 10), 13);
            g2.Visualizar();

            Vendedor v1 = new Vendedor(1, "Thais", 20, "Vendedora", 5000.00, new DateTime(2021, 05, 06), 7);
            v1.Visualizar();

            Vendedor v2 = new Vendedor(2, "Mário", 19, "Vendedor", 3000.00, new DateTime(2023, 10, 01), 5);
            v2.Visualizar();
        }
    }
}
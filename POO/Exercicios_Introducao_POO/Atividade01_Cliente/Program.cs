using Atividade01_Cliente.Model;

namespace Atividade01_Cliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente(1, "Ana", 25, "333.333.333-00", "(11)11111-1111", "exemplo@email.com");
            cliente1.Visualizar();

            Cliente cliente2 = new Cliente(2, "Joana", 40, "555.555.555-00", "(11)22222-2222", "exemplo02@email.com");
            cliente2.Visualizar();

        }
    }
}
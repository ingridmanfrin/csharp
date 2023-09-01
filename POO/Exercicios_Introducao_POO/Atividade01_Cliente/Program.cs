using Atividade01_Cliente.Model;

namespace Atividade01_Cliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente(1, "Ana", 25, "(11)22222-2222", "exemplo@email.com");
            cliente1.Visualizar();

            Cliente cliente2 = new Cliente(2, "Joana", 40, "(11)33333-3333", "exemplo02@email.com");
            cliente2.Visualizar();

            PessoaFisica pf1 = new PessoaFisica(1, "Marcelo", 20, "(11)44444-4444", "exemplo03@email.com", "999.888.000-00");
            pf1.Visualizar();

            PessoaFisica pf2 = new PessoaFisica(2, "Jonas", 60, "(11)55555-5555", "exemplo04@email.com", "888.888.000-00");
            pf2.Visualizar();

            PessoaJuridica pj1 = new PessoaJuridica(1, "Alana", 35, "(11)42244-8888", "exemplo03@email.com", "00.111.111/0001-11");
            pj1.Visualizar();

            PessoaJuridica pj2 = new PessoaJuridica(2, "Rosa", 23, "(11)99922-5555", "exemplo04@email.com", "22.222.222/0001-22");
            pj2.Visualizar();
        }
    }
}
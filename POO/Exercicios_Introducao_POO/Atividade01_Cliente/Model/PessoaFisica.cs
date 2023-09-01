using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01_Cliente.Model
{
    public class PessoaFisica : Cliente
    {
        private string cpf;

        public PessoaFisica(int id, string nome, int idade, string telefone, string email, string cpf) : base(id, nome, idade, telefone, email)
        {
            this.cpf = cpf;
        }

        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"CPF do Cliente: {this.cpf}");
        }
    }
}

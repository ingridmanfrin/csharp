using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01_Cliente.Model
{
    public class PessoaJuridica : Cliente
    {
        private string cnpj;

        public PessoaJuridica(int id, string nome, int idade, string telefone, string email, string cnpj) : base(id, nome, idade, telefone, email)
        {
            this.cnpj = cnpj;
        }
        public string GetCnpj()
        {
            return cnpj;
        }

        public void SetCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"CNPJ do Cliente: {this.cnpj}");
        }
    }
}

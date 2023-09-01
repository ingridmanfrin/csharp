using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02_Funcionario.Model
{
    internal class Vendedor : Funcionario
    {
        private float porcentagemComissao;

        public Vendedor(int id, string nome, int idade, string cargo, double salario, DateTime dataContratacao, float porcentagemComissao) : base(id, nome, idade, cargo, salario, dataContratacao)
        {
            this.porcentagemComissao = porcentagemComissao;
        }

        public float GetPorcentagemComissao()
        {
            return porcentagemComissao;
        }

        public void SetPorcentagemComissao(float porcentagemComissao)
        {
            this.porcentagemComissao = porcentagemComissao;
        }

        
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Comissão do Funcionário em porcentagem: {this.porcentagemComissao}%");
        }
    }
}

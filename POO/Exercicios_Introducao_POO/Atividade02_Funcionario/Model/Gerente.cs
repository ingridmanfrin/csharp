using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02_Funcionario.Model
{
    public class Gerente : Funcionario
    {
        private int equipes;

        public Gerente(int id, string nome, int idade, string cargo, double salario, DateTime dataContratacao, int equipes) : base(id, nome, idade, cargo, salario, dataContratacao)
        {
            this.equipes = equipes;
        }

        public int GetEquipes()
        {
            return equipes;
        }

        public void SetEquipes(int equipes)
        {
            this.equipes = equipes;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Quantidade de Equipes Gerenciadas pelo Funcionário: {this.equipes}");
        }
    }
}

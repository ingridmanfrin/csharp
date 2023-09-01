using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Atividade02_Funcionario.Model
{
    public class Funcionario
    {
        //Atributos:
        private int id;
        private string nome;
        private int idade;
        private string cargo;
        private double salario;
        private DateTime dataContratacao;

        public Funcionario(int id, string nome, int idade, string cargo, double salario, DateTime dataContratacao)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.cargo = cargo;
            this.salario = salario;
            this.dataContratacao = dataContratacao;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public string GetCargo()
        {
            return cargo;
        }

        public void SetCargo(string cargo)
        {
            this.cargo = cargo;
        }

        public double GetSalario()
        {
            return salario;
        }

        public void SetSalario(double salario)
        {
            this.salario = salario;
        }

        public DateTime GetDataContratacao()
        {
            return dataContratacao;
        }
        public void SetDataContratacao(DateTime dataContratacao)
        {
            this.dataContratacao = dataContratacao;
        }

        public void Visualizar()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Dados do Funcionário");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Id do Funcionário: {this.id}");
            Console.WriteLine($"Nome do Funcionário: {this.nome}");
            Console.WriteLine($"Idade do Funcionário: {this.idade}");
            Console.WriteLine($"Cargo do Funcionário: {this.cargo}");
            Console.WriteLine($"Salário do Funcionário: " + (this.salario).ToString("C"));
            Console.WriteLine("Data de Contratação do Funcionário: {0:d}", this.dataContratacao);

        }
    }
}

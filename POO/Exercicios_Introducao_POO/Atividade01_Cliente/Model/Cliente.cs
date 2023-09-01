using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Atividade01_Cliente.Model
{
    public class Cliente
    {
        //Atributos:
        private int id;
        private string nome;
        private int idade;
        private string telefone;
        private string email;

        public Cliente(int id, string nome, int idade, string telefone, string email)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.telefone = telefone;
            this.email = email;
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

        public string GetTelefone()
        {
            return telefone;
        }

        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }

        public virtual void Visualizar()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Dados do Cliente");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Id do Cliente: {this.id}");
            Console.WriteLine($"Nome do Cliente: {this.nome}");
            Console.WriteLine($"Idade do Cliente: {this.idade}");
            Console.WriteLine($"Telefone do Cliente: {this.telefone}");
            Console.WriteLine($"Email do Cliente: {this.email}");

        }
    }
}

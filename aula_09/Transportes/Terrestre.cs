using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    public class Terrestre : Transporte
    {
        private int rodas;
        private int velocidade;

        public Terrestre(int capacidade, int rodas, int velocidade) : base(capacidade) //base é a classe que estou herdando (ele começa a construção na superclasse e termina a construção na sub classe ( que é aqui por exemplo))
        {
            this.rodas = rodas;
            this.velocidade= velocidade;

        }

        public int GetRodas()
        {
            return rodas;
        }

        public void SetRodas(int numeroRodas)
        {
            this.rodas = numeroRodas;
        }

        public float GetVelocidade()
        {
            return velocidade;
        }

        public void SetVelocidade(int velocidade)
        {
            this.velocidade = velocidade;
        }

        //polimorfismo de sobreescrita (override):
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Número de Rodas: {rodas}");
            Console.WriteLine($"Velocidade: {velocidade}");
        }
    }
}

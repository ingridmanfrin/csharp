using Metodos_02.Namespace01;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, divisao;

            Console.WriteLine("Digite o primeiro número:");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{numero1} + {numero2} = " + Somar(numero1, numero2));
            Console.WriteLine($"{numero1} - {numero2} = " + Subtrair(numero1, numero2));
            Console.WriteLine($"{numero1} * {numero2} = " + Multiplicar(numero1, numero2));
            
            divisao = Dividir(numero1, numero2);
            Console.WriteLine(divisao == 0 ? "Não existe Divisão por zero": $"{numero1} / {numero2} = {divisao}");
            
            Console.WriteLine($"{numero1} ^ {numero2} = " + Potencia(numero1, numero2));
            Console.WriteLine($"Raiz quadrada de {numero1} = " + Raiz(numero1));
            
            Dev();

            Class02.MetodoPublico();
            //não consigo chamar o MetodoInternal pq só funciona dentro do projeto em que foi criado!
            //MetodoInternal: só funciona dentro do próprio projeto em que foi criado!
            //MetodoPrivate: é o mais fechado, so funciona dentro da propria classe (não adianta herdar o private: não dá para acessar de fora da classe onde foi criado) 
            //MetodoProtegido: só dá para usar na mesma classe que foi criada, ou a outra classe estiver herdando
            //MetodoPublic: dá para acessar em tudo
        }

        static float Somar(float numero1, float numero2)
        {
            return numero1 + numero2;  
        }
        
        static float Subtrair(float numero1, float numero2)
        {
            return numero1 - numero2;
        }
        
        static float Multiplicar(float numero1, float numero2)
        {
            return numero1 * numero2;
        }
        
        static float Dividir(float numero1, float numero2)
        {
            if (numero2 > 0)
            {
                return numero1 / numero2;
            }
            else
            {
                return 0;
            }
        }
        
        static double Potencia(float numero1, float numero2)
        {
                return Math.Pow(numero1,  numero2);
        }
        
        static double Raiz(float numero1)
        {
            return Math.Sqrt(numero1);
        }
        
        static void Dev()
        {
            Console.WriteLine("Criado por: Ingrid");
        }
    }
}
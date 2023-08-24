namespace Notas
{
    internal class Program             
    {
        static void Main(string[] args)       //exemplo de if ternário
        {
            float nota1, nota2, media;

            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToSingle(Console.ReadLine());

            media = (nota1 + nota2) / 2;
                                                                             // if ternário com 2 condições
            Console.WriteLine((media >= 6) ? "Aprovado!" : "Reprovado!");    //o que está antes da ? é a condição, depois dos : é colocado o que fazer quando a condição não for satisfeita

            // (condição) ? ação verdade : ação para falso

            //Console.WriteLine((media >= 6) ? "Aprovado!" : (media >= 4 && media < 6) ? "Exame" : "Reprovado!"); //if ternário com 3 condições.
        }
    }
}
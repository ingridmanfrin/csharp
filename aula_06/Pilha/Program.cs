namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pode utilizar para controlar uma pilha de livros (as pessoas peguam o primeiro da pilha, que foi o último a ser colocado).
            Stack<string> pilha = new Stack<string>();

            //Este método é usado para adicionar um elemento no topo da pilha.
            pilha.Push("Breno");
            pilha.Push("Eduardo");
            pilha.Push("Julia");
            pilha.Push("Leonardo");
            pilha.Push("Gaspar");

            //Este método é usado para remover um elemento no topo da pilha.
            pilha.Pop();

            foreach (var nome in pilha)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("Quem é o último da pilha? " + pilha.Peek());

            Console.WriteLine("O Gaspar faz parte da pilha? " + pilha.Contains("Gaspar"));

            Console.WriteLine("Numero de pessoas que estão na pilha: " + pilha.Count());
        }
    }
}
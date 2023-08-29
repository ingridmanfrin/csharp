namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //funciona muito para um sistema de senha, ou quando tem que se respeitar a ordem que o primeiro que entrou é o primeiro a sair.
            Queue<string> fila = new Queue<string>();

            //Este método é usado para adicionar um elemento no final da fila.
            fila.Enqueue("Breno");
            fila.Enqueue("Eduardo");
            fila.Enqueue("Julia");
            fila.Enqueue("Leonardo");
            fila.Enqueue("Gaspar");

            //Este método é usado para remover o primeiro elemento da fila.
            fila.Dequeue();

            foreach (var nome in fila)
            {
                Console.WriteLine(nome);
            }

            //Este método é usado para exibir, mas não remover, o elemento que está sendo apontado pelo ponteiro HEAD desta fila (o primeiro elemento), ou retornar nulo se esta fila estiver vazia.
            Console.WriteLine("Quem é o primeiro da fila? " + fila.Peek());

            //Este método é usado para verificar se a fila contém o elemento fornecido ou não. Retorna true se a fila contiver o elemento.
            Console.WriteLine("O Gaspar entrou na fila? " + fila.Contains("Gaspar"));

            //Este método é usado para retornar o tamanho da fila.
            Console.WriteLine("Numero de pessoas na fila: " + fila.Count());
        
        }
    }
}
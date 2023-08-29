namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();

            //Adicionar novos elementos
            notas.Add(7.0);
            notas.Add(5.0);
            notas.Add(4.0);
            notas.Add(7.0);
            notas.Add(10.0);

            //nota é o elemento e notas é a coleção de dados
            foreach (double nota in notas) 
            {
                Console.WriteLine(nota);    
            }

            Console.WriteLine("Posição da nota 4.0: " + notas.IndexOf(4.0));

            Console.WriteLine("A nota 4.0 existe? " + notas.Contains(4.0)); //vai dizer em true e false se existe ou não

            notas.Remove(4.0); //remove a nota que passei dentro dos parênteses

            foreach (double nota in notas) 
            {
                Console.WriteLine(nota);
            }
           
            Console.WriteLine("Posição da nota 10.0: " + notas.IndexOf(10.0));

            Console.WriteLine("Quantos elementos tem a lista? " + notas.Count);

            //vai ordenar as notas em ordem crescente
            notas.Sort(); 

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine();    

            notas.Reverse(); //vai ordenar as notas em ordem descrescrente

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine();

            notas[0] = 9.0; //alteração em uma posição expecifica da lista

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            //no foreach vc pode usar o var, mas nem em todas as situações dá para usar
            //não pode usar o var para criar um objeto novo por exemplo. Mas para situações que vc consegue inferir o tipo do var, pode usar o var
            //não pode usar o var: definição de modelo de dados de uma variável???
        }
    }
}
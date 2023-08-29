namespace CollectionList_Lista01_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEncontrar;

            List<int> numeros = new List<int>();
            
            numeros.Add(2);
            numeros.Add(5);
            numeros.Add(1);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(9);
            numeros.Add(7);
            numeros.Add(8);
            numeros.Add(10);
            numeros.Add(6);

            Console.WriteLine("Dado a Lista: \n");
            foreach (int numero in numeros)
            {
                Console.Write($" { numero} |");
            }

            Console.Write("\n\nDigite o número que você deseja encontrar: ");
            numeroEncontrar = Convert.ToInt32(Console.ReadLine());

            if (numeros.IndexOf(numeroEncontrar) != -1)
            {
                Console.WriteLine($"\nO número {numeroEncontrar} está localizado na posição: " + numeros.IndexOf(numeroEncontrar));
            }
            else
            {
                Console.WriteLine($"\nO número {numeroEncontrar} não foi encontrado!");
            }
        }
    }
}
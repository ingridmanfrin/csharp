namespace CollectionHashSet_Lista02_Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEncontrar;

            HashSet<int> setNumeros = new HashSet<int>()
            {
                2,5,1,3,4,9,7,8,10,6,
            };

            Console.WriteLine("Dado a Lista: \n");
            foreach (int numero in setNumeros)
            {
                Console.Write($" {numero} |");
            }
            
            Console.Write("\n\nDigite o número que você deseja encontrar: ");
            numeroEncontrar = Convert.ToInt32(Console.ReadLine());

            if (setNumeros.Contains(numeroEncontrar) == true)
            {
                Console.WriteLine($"\nNúmero {numeroEncontrar} foi encontrado!");
            }
            else
            {
                Console.WriteLine($"\nO número {numeroEncontrar} não foi encontrado!");
            }

        }
    }
}
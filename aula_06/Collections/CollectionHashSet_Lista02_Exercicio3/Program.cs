namespace CollectionHashSet_Lista02_Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> setNumeros = new HashSet<int>();

            Console.WriteLine("Digite 10 números inteiros: ");
            for (int indice = 0; indice < 10; indice++)
            {
                int numero;
                numero = Convert.ToInt32(Console.ReadLine());
                setNumeros.Add(numero);
            }

            Console.WriteLine("\nListar dados do HashSet: ");
            foreach (var numero in setNumeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
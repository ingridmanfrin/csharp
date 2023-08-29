namespace CollectionList_Lista01_Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string cor1, cor2, cor3, cor4, cor5;

            //Console.WriteLine("Digite 5 cores: ");
            //cor1 = Console.ReadLine();
            //cor2 = Console.ReadLine();
            //cor3 = Console.ReadLine();
            //cor4 = Console.ReadLine();
            //cor5 = Console.ReadLine();

            //List<string> cores = new List<string>();

            //cores.Add(cor1);
            //cores.Add(cor2);
            //cores.Add(cor3);
            //cores.Add(cor4);
            //cores.Add(cor5);

            List<string> cores = new List<string>();

            Console.WriteLine("Digite 5 cores: ");
            for (int indice = 0; indice < 5; indice++)
            {
                string cor;
                cor = Console.ReadLine();
                cores.Add(cor);
            }

            Console.WriteLine($"\nListar todas as cores: \n");
            foreach (string cor in cores)
            {
                Console.WriteLine(cor);
            }

            Console.WriteLine($"\nOrdenar as cores: \n");
            cores.Sort();
            foreach (string cor in cores)
            {
                Console.WriteLine(cor);
            }
        }
    }
}
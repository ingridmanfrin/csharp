namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] vetor02 = new int[5];

            string[] vetor03 = { "Allan", "Ingrid", "João", "Gabriel", "Shomara", "Karina", "Jacque", "Ingrid" };

            //for (int indice = 0; indice < 10; indice++)
            //{
            //    Console.WriteLine($"vetor01[{indice}] = {vetor01[indice]}");
            //}

            Console.WriteLine("\n");

            for (int indice = 0; indice < 5; indice++)
            {
                Console.Write($"vetor02[{indice}] = ");
                vetor02[indice] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n");

            Array.Sort(vetor02);  //ordena 

            for (int indice = 0; indice < vetor02.Length; indice++) //vetor02.Length propriedade Lenght vai trazer o tamanho do vetor é como se a gente colocasse indice<5 nesse exemplo
            {
                Console.WriteLine($"vetor02[{indice}] = {vetor02[indice]}");
            }

            //Console.WriteLine("\n");

            //Array.Reverse(vetor02);  //ordena em ordem descrescente

            //for (int indice = 0; indice < vetor02.Length; indice++) //vetor02.Length propriedade Lenght vai trazer o tamanho do vetor é como se a gente colocasse indice<5 nesse exemplo
            //{
            //    Console.WriteLine($"vetor02[{indice}] = {vetor02[indice]}");
            //}

            //Console.WriteLine("\n");

            //Array.Sort(vetor03);  //ordena 

            //for (int indice = 0; indice < vetor03.Length; indice++) //vetor02.Length propriedade Lenght vai trazer o tamanho do vetor é como se a gente colocasse indice<5 nesse exemplo
            //{
            //    Console.WriteLine($"vetor03[{indice}] = {vetor03[indice]}");
            //}

            //Console.WriteLine("Qual é a posição da Ingrid no vetor: " + Array.IndexOf((vetor03), "Ingrid"));

            //Console.WriteLine("Qual é a posição da Ingrid no vetor: " + Array.BinarySearch((vetor03), "Ingrid"));  //se tiver dois elementos repetidos ele não vai conseguir encontrar

            ////imprimir elementos pares

            //Console.WriteLine("\n");

            //for (int indice = 0; indice < vetor01.Length; indice++)
            //{
            //    if (vetor01[indice] % 2 == 0)
            //    {
            //        Console.WriteLine($"vetor01[{indice}] = {vetor01[indice]}");
            //    }
            //}
        }
    }
}
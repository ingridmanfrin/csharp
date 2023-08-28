namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz01 = { {1,2,3 },{4,5,6 },{7,8,9 } };

            int[,] matriz02 = new int[4, 4];

            int[,] matriz03 = { { 1, 2, 3 }, { 4, 5, 6 } };

            int[] vetor = { 1, 2, 3, 4, 5 };

            int soma = 0;

            //matriz01

            //for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz01.Length); indiceLinha++)  //Sqrt : raiz quadrada. Só funciona se sua matriz for quadrada!!!
            //{
            //    for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz01.Length); indiceColuna++)
            //    {
            //        int elemento = matriz01[indiceLinha, indiceColuna];
            //        Console.WriteLine($"matriz01[{indiceLinha}, {indiceColuna}] = {elemento}");
            //    }
            //}

            //matriz02

            //Console.WriteLine();

            //for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz02.Length); indiceLinha++)  //Sqrt : raiz quadrada. Só funciona se sua matriz for quadrada!!!
            //{
            //    for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz02.Length); indiceColuna++)
            //    {
            //        Console.Write($"matriz02[{indiceLinha}, {indiceColuna}] = ");
            //        matriz02[indiceLinha, indiceColuna] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine();

            //for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz02.Length); indiceLinha++)
            //{
            //    for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz02.Length); indiceColuna++)
            //    {
            //        Console.WriteLine($"matriz02[{indiceLinha}, {indiceColuna}] = {matriz02[indiceLinha, indiceColuna]}");
            //    }
            //}

            //matriz03 matriz irregualar

            //    for (int indiceLinha = 0; indiceLinha < matriz03.GetLength(0); indiceLinha++)
            //    {
            //        for (int indiceColuna = 0; indiceColuna < matriz03.GetLength(1); indiceColuna++)
            //        {
            //            Console.WriteLine($"matriz03[{indiceLinha}, {indiceColuna}] = {matriz03[indiceLinha, indiceColuna]}");
            //        }
            //    }

            foreach (int elemento in vetor)
            {
                Console.WriteLine(elemento);
            }
            Console.WriteLine();
            foreach (int elemento in matriz01)
            {
                //elemento = matriz01[indiceLinha, indiceColuna];

                soma += elemento;

                if (elemento % 3 == 0)
                {
                    Console.WriteLine(elemento);

                }
            }

            Console.WriteLine(soma);
        }
    }
}
namespace Lista02_Matrizes_Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matrizNotas = new double[10, 4];

            double[] vetorMedia = new double[10];

            for (int indiceLinha = 0; indiceLinha < matrizNotas.GetLength(0); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < matrizNotas.GetLength(1); indiceColuna++)
                {
                    Console.Write($"matriz[{indiceLinha}, {indiceColuna}] = ");
                    matrizNotas[indiceLinha, indiceColuna] = Convert.ToDouble(Console.ReadLine());
                }

            }

            for (int linha = 0; linha < matrizNotas.GetLength(0); linha++) 
            {
                double soma = 0;

                for (int coluna = 0; coluna < matrizNotas.GetLength(1); coluna++)
                {
                    // Armazena a soma dos elementos da linha na variável soma
                    soma += matrizNotas[linha, coluna];
                }

                // Guarda a media no vetor auxiliar
                vetorMedia[linha] = soma / 4;

                //soma = 0; //não preciso dessa linha pq como a minha variavel soma está local, ela irá se autoapagar a cada iteração do for
            }

            Console.WriteLine();

            for (int indice = 0; indice < vetorMedia.Length; indice++)
            {
                Console.Write($"{vetorMedia[indice]: 0.0} | ");
            }

        }
    }
}
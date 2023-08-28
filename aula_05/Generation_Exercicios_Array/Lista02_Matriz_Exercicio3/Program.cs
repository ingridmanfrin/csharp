namespace Lista02_Matriz_Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int somaPincripal = 0, somaSecundaria = 0;
            string diagonalPrincipal = "", diagonalSecundaria = "";

            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz.Length); indiceLinha++)  //Sqrt : raiz quadrada(que é o contrário de elevado: 3 elevado à 3). Só funciona se sua matriz for quadrada!!!
            {
                for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz.Length); indiceColuna++)
                {
                    Console.Write($"matriz[{indiceLinha}, {indiceColuna}] = ");
                    matriz[indiceLinha, indiceColuna] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int indice = 0; indice < Math.Sqrt(matriz.Length); indice++) //o indice da coluna e linha são os mesmos em cada elemento 0,0- 1,1 -2,2
            {
                diagonalPrincipal += matriz[indice, indice] + " ";
                somaPincripal += matriz[indice, indice];
            }

            for (int indice = 0; indice < Math.Sqrt(matriz.Length); indice++) 
            {
                diagonalSecundaria += matriz[indice,(int)(Math.Sqrt(matriz.Length) - 1 - indice)] + " ";
                somaSecundaria += matriz[indice, (int)(Math.Sqrt(matriz.Length) - 1 - indice)];
            }

            Console.WriteLine("\nElementos da Diagonal Principal:\n" + diagonalPrincipal);
            Console.WriteLine("\nSoma da Diagonal Principal:\n" + somaPincripal);
            Console.WriteLine("\nElementos da Diagonal Secundária:\n" + diagonalSecundaria);
            Console.WriteLine("\nSoma da Diagonal Secundária:\n" + somaSecundaria);

        }
    }
}
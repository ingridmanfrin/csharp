namespace Lista2_LacoWhile_Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade=0, pessoasMenor21=0, pessoasMaior50=0 ;

            while (idade >= 0) 
            {
                Console.WriteLine("Digite uma idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade < 21 && idade >=0)
                {
                    pessoasMenor21++;
                }
                if (idade > 50)
                {
                    pessoasMaior50++;
                }
            }

            Console.WriteLine($"Total de pessoas Menores de 21 anos: {pessoasMenor21}");
            Console.WriteLine($"Total de pessoas Maiores de 50 anos: {pessoasMaior50}");

        }
    }
}
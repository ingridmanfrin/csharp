namespace Lista1_Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            bool primeiraDoacao = true;

            Console.Write("Digite o Nome do doador: ");
            nome = Console.ReadLine();

            Console.Write("Digite o Idade do doador: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Primeiro doação? ");
            primeiraDoacao = Convert.ToBoolean(Console.ReadLine());

            if (idade >= 18 && idade < 60)
            {
                Console.WriteLine($"\n{nome} está apto(a) para doar sangue! ");
            }
            else if (idade < 18 || idade > 69)
            {
                Console.WriteLine($"\n{nome} não está apto(a) para doar sangue! ");
            }
            else if (idade >= 60 && idade <= 69 && primeiraDoacao == true)
            {
                Console.WriteLine($"\n{nome} não está apto(a) para doar sangue!");
            }
            else
            {
                Console.WriteLine($"\n{nome} está apto(a) para doar sangue!");
            }
        }
    }
}
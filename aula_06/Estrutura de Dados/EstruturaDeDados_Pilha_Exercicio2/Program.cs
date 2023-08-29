namespace EstruturaDeDados_Pilha_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuEscolhido = -1;
            string nome;

            //criando uma fila em branco
            Stack<string> pilhaLivros = new Stack<string>();

            while (menuEscolhido != 0)
            {
                Console.WriteLine("***********************************************");
                Console.WriteLine("\t");
                Console.WriteLine("\t1 - Adicionar Livro na pilha");
                Console.WriteLine("\t2 - Listar todos os Livros");
                Console.WriteLine("\t3 - Retirar Livro da pilha");
                Console.WriteLine("\t0 - Sair");
                Console.WriteLine("\t");
                Console.WriteLine("***********************************************");
                Console.WriteLine("Entre com a opção desejada:\t");
                Console.WriteLine("\t");

                Console.Write("\nDigite uma opção: ");
                menuEscolhido = Convert.ToInt32(Console.ReadLine());

                switch (menuEscolhido)
                {
                    case 1:
                        Console.Write("\nDigite o nome: ");
                        nome = Console.ReadLine();
                        pilhaLivros.Push(nome);

                        Console.WriteLine("\nPilha: \n");
                        foreach (string livro in pilhaLivros)
                        {
                            Console.WriteLine($"{livro}");
                        }
                        Console.WriteLine("\nLivro Adicionado!\n");
                        break;
                    case 2:
                        Console.Write("\nLista de Livros na Pilha: \n");
                        foreach (string livro in pilhaLivros)
                        {
                            Console.WriteLine($"{livro}");
                        }
                        break;
                    case 3:
                        if (pilhaLivros.Count == 0) //fila.Count retorna um inteiro por isso fiz = 0 para fila vazia
                        {
                            Console.WriteLine("\nA Pilha está vazia!");
                        }
                        else
                        {
                            pilhaLivros.Pop();
                            Console.WriteLine("\nPilha: \n");
                            foreach (string livro in pilhaLivros)
                            {
                                Console.WriteLine($"{livro}");
                            }
                            Console.WriteLine("\nUm Livro foi retirado da pilha!\n");
                        }
                        break;
                }

            }

            Console.WriteLine("\nPrograma Finalizado!");
        }
    }
}
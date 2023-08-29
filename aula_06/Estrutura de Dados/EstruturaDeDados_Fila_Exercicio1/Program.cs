namespace EstruturaDeDados_Fila_Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuEscolhido = -1;
            string nome;

            //criando uma fila em branco
            Queue<string> fila = new Queue<string>();

            while (menuEscolhido != 0)
            {
                Console.WriteLine("***********************************************");
                Console.WriteLine("\t");
                Console.WriteLine("        1 - Adicionar Cliente na Fila          ");
                Console.WriteLine("        2 - Listar todos os Clientes           ");
                Console.WriteLine("        3 - Retirar Cliente da Fila            ");
                Console.WriteLine("        0 - Sair                               ");
                Console.WriteLine("                                               ");
                Console.WriteLine("***********************************************");
                Console.WriteLine("Entre com a opção desejada:                    ");
                Console.WriteLine("                                               ");

                Console.Write("\nDigite uma opção: ");
                menuEscolhido = Convert.ToInt32(Console.ReadLine());

                switch (menuEscolhido)
                {
                    case 1:
                        Console.Write("\nDigite o nome: ");
                        nome = Console.ReadLine();
                        fila.Enqueue(nome);

                        Console.WriteLine("\nFila: \n");
                        foreach (string cliente in fila)
                        {
                            Console.WriteLine($"{cliente}\n");
                        }
                        Console.WriteLine("Cliente Adicionado!\n");
                        break;
                    case 2:
                        Console.Write("\nLista de Clientes na Fila: \n");
                        foreach (string cliente in fila)
                        {
                            Console.WriteLine($"{cliente}\n");
                        }
                        break;
                    case 3:
                        if (fila.Count == 0) //fila.Count retorna um inteiro por isso fiz = 0 para fila vazia
                        {
                            Console.WriteLine("A Fila está vazia!");
                        }
                        else
                        {
                            fila.Dequeue();
                            Console.WriteLine("\nFila: \n");
                            foreach (string cliente in fila)
                            {
                                Console.WriteLine($"{cliente}\n");
                            }
                            Console.WriteLine("O Cliente foi Chamado!\n");
                        }
                        break;
                }

            }
            Console.WriteLine("Programa Finalizado!");
        }
    }
}
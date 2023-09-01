namespace Lista1_Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? palavra1, palavra2, palavra3;

            Console.WriteLine("Digite a primeira palavra: ");
            palavra1 = Console.ReadLine();

            Console.WriteLine("Digite a primeira segunda: ");
            palavra2 = Console.ReadLine();

            Console.WriteLine("Digite a primeira terceira: ");
            palavra3 = Console.ReadLine();

            if (palavra1 is not null && palavra2 is not null && palavra3 is not null)
            {
                //verificando se é vertebrado ou Invertebrado
                if (palavra1.Equals("vertebrado"))
                {
                    //verificando se é Ave ou Mamífero
                    if (palavra2.Equals("ave"))
                    {
                        if (palavra3.Equals("carnívoro"))
                        {
                            Console.WriteLine("Águia");
                        }
                        else
                        {
                            Console.WriteLine("Pomba");

                        }
                    }
                    else
                    {
                        if (palavra3.Equals("onívoro", StringComparison.CurrentCultureIgnoreCase)) //fazer funcionar mesmo sem acento (trazer a palavra Homem)!!!
                        {
                            Console.WriteLine("Homem");
                        }
                        else
                        {
                            Console.WriteLine("Vaca");

                        }
                    }
                }
                else
                {
                    //verificando se é inseto ou anelídeo
                    if (palavra2.Equals("inseto"))
                    {
                        if (palavra3.Equals("hematófago"))
                        {
                            Console.WriteLine("pulga");
                        }
                        else
                        {
                            Console.WriteLine("lagarta");

                        }
                    }
                    else
                    {
                        if (palavra3.Equals("onívoro"))
                        {
                            Console.WriteLine("Minhoca");
                        }
                        else
                        {
                            Console.WriteLine("Sanguessuga");

                        }
                    }

                }
            }
            else
            {
                Console.WriteLine("As palavras não podem ser nulas!");
            }

        }
    }
}

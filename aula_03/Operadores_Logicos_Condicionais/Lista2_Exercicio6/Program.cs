namespace Lista2_Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, cargo="";
            int codigoCargo;
            float salario, reajuste=0;

            Console.Write("Nome do colaborador: ");
            nome = Console.ReadLine();

            Console.Write("Código do Cargo: ");
            codigoCargo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (codigoCargo) 
            {
                case 1:
                    cargo = "Gerente";
                    reajuste = (salario * 10) / 100;
                    break;
                case 2:
                    cargo = "Vendedor";
                    reajuste = (salario * 7) / 100;
                    break;
                case 3:
                    cargo = "Supervisor";
                    reajuste = (salario * 9) / 100;
                    break;
                case 4:
                    cargo = "Motorista";
                    reajuste = (salario * 6) / 100;
                    break;
                case 5:
                    cargo = "Estoquista";
                    reajuste = (salario * 5) / 100;
                    break;
                case 6:
                    cargo = "Técnico de TI";
                    reajuste = (salario * 8) / 100;
                    break;
            }
            Console.WriteLine($"\nNome do colaborador: {nome}");
            Console.WriteLine($"\nCargo: {cargo}");
            Console.WriteLine($"\nSalário: R${salario + reajuste: 0.00}");


        }
    }
}
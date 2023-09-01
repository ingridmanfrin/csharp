using Metodos_02.Namespace01;

namespace Metodos_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodoPublico();
            MetodoInternal();
            MetodoProtegido();
            MetodoPrivado();

            Class01.MetodoPublico();
            //consigo usar o metodointernal pq está dentro do mesmo projeto
            Class01.MetodoInternal();
            //não consigo usar o MetodoProtegido por não ter herança
            //Class01.MetodoProtegido();
            //não consigo usar o MetodoPrivado pois só a class01 terá acesso
            //Class01.MetodoPrivado();

            Class02.MetodoPublico();
            Class02.MetodoInternal();
            //Class02.MetodoProtegido();
            //Class02.MetodoPrivado();
        }

       
        //Os quatro modificadores de acesso:
        public static void MetodoPublico()
        {
            Console.WriteLine("Metodo Público - Classe Program");
        }

        internal static void MetodoInternal()
        {
            Console.WriteLine("Metodo Internal - Classe Program");
        }

        protected static void MetodoProtegido()
        {
            Console.WriteLine("Metodo Protegido - Classe Program");
        }

        private static void MetodoPrivado()
        {
            Console.WriteLine("Metodo Privado - Classe Program");
        }
    }
}
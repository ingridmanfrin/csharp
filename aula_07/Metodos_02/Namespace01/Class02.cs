using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_02.Namespace01
{
    public class Class02
    {
        //Os quatro modificadores de acesso:
        public static void MetodoPublico()
        {
            Console.WriteLine("Metodo Público - Classe 02");
        }

        internal static void MetodoInternal()
        {
            Console.WriteLine("Metodo Internal - Classe 02");
        }

        protected static void MetodoProtegido()
        {
            Console.WriteLine("Metodo Protegido - Classe 02");
        }

        private static void MetodoPrivado()
        {
            Console.WriteLine("Metodo Privado - Classe 02");
        }
    }
}

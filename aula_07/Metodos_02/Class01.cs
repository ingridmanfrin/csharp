using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_02
{
    public class Class01
    {
        //Os quatro modificadores de acesso:
        public static void MetodoPublico()
        {
            Console.WriteLine("Metodo Público - Classe 01");
        }

        internal static void MetodoInternal()
        {
            Console.WriteLine("Metodo Internal - Classe 01");
        }

        protected static void MetodoProtegido()
        {
            Console.WriteLine("Metodo Protegido - Classe 01");
        }

        private static void MetodoPrivado()
        {
            Console.WriteLine("Metodo Privado - Classe 01");
        }
    }
}

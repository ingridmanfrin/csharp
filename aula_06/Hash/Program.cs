namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setNomes = new HashSet<string>() 
            {
                "Allan",
                "Robson",
                "João",
                "Ingrid",
                "Allan",
                "Robson",
            };
            
            foreach (var nome in setNomes) 
            {
                Console.WriteLine(nome);
            }

            setNomes.Add("Samantha");
            setNomes.Add(null);
            setNomes.Add("Julia");

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            //ver se elemento existe dentro do hash
            Console.WriteLine("O nome Julia existe? " + setNomes.Contains("Julia"));

            setNomes.Remove("João");
            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            //converter hashSet em uma List e ordenar 
            List<string> hashList = setNomes.ToList();

            hashList.Sort();

            foreach (var hash in hashList)
            {
                Console.WriteLine(hash);
            }
        }
    }
}
using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tittle = "Azerbaycan dovletinin illik budcesinin ortalama olaraq 20 milyard dollardir";
            Console.WriteLine(tittle);

            long budget = 20000000000;
            float MN = 0.2f;
            float YTN = 0.1f;
            float Qaliq = 0.7f;

            string name = "Budce:";
            Console.WriteLine(name);
            float budce1 = budget;
            Console.WriteLine(budce1);

            Console.WriteLine("");

            string name1 = "Mudafie Nazirliyine:";
            Console.WriteLine(name1);
            float Mudafie = budget * MN;
            Console.WriteLine(Mudafie);

            Console.WriteLine("");

            string name2 = "Yuksek Texnologiyalar Nazirliyine:";
            Console.WriteLine(name2);
            float Yuksek= budget * YTN;
            Console.WriteLine(Yuksek);

            Console.WriteLine("");

            string name3 = "Yerde qalan budce:";
            Console.WriteLine(name3);
            float Qalan = budget * Qaliq;
            Console.WriteLine(Qalan);






        }
    }
}

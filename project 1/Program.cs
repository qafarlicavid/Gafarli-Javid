using System;

namespace project 1
{
    class Program
    {
        static void Main(string[] args)
        {
            int azn = 1000;
            float usd = 0.5882f;
            float eur = 0.547f;
            float rub = 37.7359f;

            string test1 = "1000 azn nece usd-dir?";
            Console.WriteLine(test1);
            float multiplication1 = azn * usd;
            Console.WriteLine(multiplication1);

            Console.WriteLine("");

            string test2 = "1000 azn nece eur-dur";
            Console.WriteLine(test2);
            float multiplication2 = azn * eur;
            Console.WriteLine(multiplication2);

            Console.WriteLine("");

            string test3 = "1000 azn nece rub-dur";
            Console.WriteLine(test3);
            float multiplication3 = azn * rub;
            Console.WriteLine(multiplication3);

            


        }
    }
}

using System;

namespace project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Firma:";
            Console.WriteLine(name);
            string firma = "Adidas";
            Console.WriteLine(firma);
            string adidas = "Ayaqqabi sayi:";
            Console.WriteLine(adidas);
            int say = 4;
            Console.WriteLine(say);
            string qiymet = "Birinin qiymeti ($):";
            Console.WriteLine(qiymet);
            int birininQiymeti = 200;
            Console.WriteLine(birininQiymeti);
            string all = "Hamisinin birlikde qiymeti($):";
            Console.WriteLine(all);
            int allQiymet = say * birininQiymeti;
            Console.WriteLine(allQiymet);

            Console.WriteLine("");

            string name1 = "Firma:";
            Console.WriteLine(name1);
            string firma1 = "Gucci";
            Console.WriteLine(firma1);
            string gucci = "Ayaqqabi sayi:";
            Console.WriteLine(gucci);
            int say1 = 2;
            Console.WriteLine(say1);
            string qiymet1 = "Birinin qiymeti ($):";
            Console.WriteLine(qiymet1);
            int birininQiymeti1 = 1000;
            Console.WriteLine(birininQiymeti1);
            string all1 = "Hamisinin birlikde qiymeti($):";
            Console.WriteLine(all1);
            int allQiymet1 = say1 * birininQiymeti1;
            Console.WriteLine(allQiymet1);

            Console.WriteLine("");

            string name2 = "Firma:";
            Console.WriteLine(name2);
            string firma2 = "Nike";
            Console.WriteLine(firma2);
            string Nike = "Ayaqqabi sayi:";
            Console.WriteLine(Nike);
            int say2 = 1;
            Console.WriteLine(say2);
            string qiymet2 = "Birinin qiymeti ($):";
            Console.WriteLine(qiymet2);
            int birininQiymeti2 = 150;
            Console.WriteLine(birininQiymeti2);
            string all2 = "Hamisinin birlikde qiymeti($):";
            Console.WriteLine(all2);
            int allQiymet2 = say2 * birininQiymeti2;
            Console.WriteLine(allQiymet2);

            Console.WriteLine("");

            string end = "Yekun xerclenen mebleg :";
            Console.WriteLine(end);
            int sonMebleg = allQiymet + allQiymet1 + allQiymet2;
            Console.WriteLine(sonMebleg);


            Console.WriteLine();
        }
    }
}

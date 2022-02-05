using System;

namespace Solution_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7) verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir 

            int a = 1245;
            bool dogru = a >= 1000 && a < 10000;
            if (!dogru)
            {
                Console.WriteLine("4 reqemli deyil");
            }
            int qaliq;
            int a1 = 0; //yeni ededimiz
            while (a>0)
            {
                qaliq = a % 10;
                a /= 10;
                Console.WriteLine(qaliq);
                a1 = a1 * 10 + qaliq;
            }          
            a1 = a1 * 10 + 8;
            a1 = a1 + 8 * 100000;
            Console.WriteLine("ededi tersine duz sonuna ve evveline 8 artir" +a1);
        }
    }
}

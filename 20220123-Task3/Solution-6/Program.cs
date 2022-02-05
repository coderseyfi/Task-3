using System;

namespace Solution_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6) verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et

            int a = 12345678;
            bool isSuccess = a >= 10000000 && a < 100000000;
            if (!isSuccess)
            {
                Console.WriteLine("8 reqemli deyil");
            }
            Console.WriteLine("ilkin ededimiz : " +a);
            a = a / 10;
             //1234567

            int qaliq; 
            int yeniEd = 0;
            while (a>0)
            {
                qaliq = a % 10;
                a = a / 10;
                yeniEd = yeniEd * 10 + qaliq;
            }
           
            yeniEd = yeniEd / 10;
            int qal2;
            int soned= 0;
            while (yeniEd > 0)
            {
                qal2 = yeniEd % 10;
                yeniEd = yeniEd / 10;
                soned = soned * 10 + qal2;
            }
            Console.WriteLine("son eded : " +soned);

        }
    }
}

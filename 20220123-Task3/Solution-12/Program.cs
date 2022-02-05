using System;

namespace Solution_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // 12) 2 dene 5 reqemli eded daxil et.
            //I ededin reqemleri ceminin usutne
            //II ededin reqemleri hasilini gel.
            //Neticenin axirina I ededin en axiinci reqemini artir.

            int a = 12345;
            int b = 23456;
            int aLast;
            int totalSum = 0;
            bool isSuccess = a >= 10000 && a < 100000 && b >= 10000 && b < 100000;
            if (!isSuccess)
            {
                Console.WriteLine("5 reqemli deyil");
                return;
            }

            aLast = a % 10;
            

            int qaliq;
            int aSum = 0;
            while (a>0)
            {
                qaliq = a % 10;
                a = a / 10;
                aSum = aSum + qaliq;
            }
            Console.WriteLine(aSum);

            

            int qaliq1;
            int bHasil = 1;
            while (b > 0)
            {
                qaliq1 = b % 10;
                b = b / 10;
                bHasil = bHasil * qaliq1;
            }
            Console.WriteLine(bHasil);

            totalSum = aSum + bHasil;
            Console.WriteLine("1ci ededin reqemleri cemi uste gel 2ci ededin reqemleri hasili : " +totalSum);

            totalSum = totalSum * 10 + aLast;
            Console.WriteLine("neticenin sonuna 1ci ededin axrinci reqemini artir : " + totalSum);
        }
    }
}

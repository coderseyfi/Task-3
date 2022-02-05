using System;

namespace solution_9
{
    class Program
    {
        static void Main(string[] args)
        {

            // 9) 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389 = 12439

            int a = 123456789;
            bool dogru = a >= 100000000 && a < 1000000000;
            if (!dogru)
            {
                Console.WriteLine("9 reqemli deyil");
            }
            int qaliq;
            int counter = 1;
            int newNum = 0;
            while (a>0)
            {
                qaliq = a % 10;
                a = a / 10;
              
                if (counter %2 !=0)
                {
                     newNum = newNum * 10 + qaliq;
                }
                counter++;
            }
            Console.WriteLine(newNum);

          
        }
    }
}

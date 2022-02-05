using System;

namespace Solution_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
            // sonra cut yerde dayanlarinda bir eded duzlet,
            // sonra onlari topla

            int a = 567893216;
            int a1=0; // tek yerde duran
            int a2=0; // cut yerde duran
           
            bool dogru = a >= 100000000 && a < 1000000000;
            if (!dogru)
            {
                Console.WriteLine("9 reqemli deyil");
                return;
            }

            int counter = 1; //1 2 3 4 5 
            int qaliq;
            int totalSum = 0;

            int qaliq1;
            int newNum = 0;

            while (a>0)
            {
                qaliq1 = a % 10;
                a = a / 10;
                newNum = newNum * 10 + qaliq1;

            }


            while (newNum>0)
            {
                qaliq = newNum % 10;
                if (counter %2 !=0)
                {                   
                    a1 = a1*10 + qaliq; // 
                }
                else
                {                   
                    a2 = a2*10 + qaliq; // 
                }
                counter++;
                newNum = newNum / 10;
            }
            Console.WriteLine("tek yerde duran : " + a1);
            Console.WriteLine("cut yerde duran: " + a2);

            totalSum = a1 + a2;
            Console.WriteLine("bunlarin cemi : " +totalSum);
            
        }
    }
}

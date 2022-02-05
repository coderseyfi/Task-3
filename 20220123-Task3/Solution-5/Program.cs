using System;

namespace Solution_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5) verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.

            int a = 123456; //234561
            bool isSuccess = a >= 100000 && a < 1000000;
            if (!isSuccess)
            {
                Console.WriteLine("6 reqemli deyil");
                return;
            }

            Console.WriteLine("ilkin eded : " +a);
            int a1;

            a1 = a / 100000;
            a = a * 10 + a1;
            Console.WriteLine("1ci reqemi ededin axirina elave et : " +a);

            
            

             
            

           

        } 
    }
}

using System;

namespace Solution_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3) verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi

            int a = 123456789;
            
            bool isSuccess = a >= 100000000 && a < 1000000000;

            if (!isSuccess)
            {
                Console.WriteLine("9 reqemli deyil");

                return;
            }

            Console.WriteLine("ilkin ededimiz : " + a);

            a = a / 1000;
            a %= 1000; //456
            Console.WriteLine("ortada duran reqemler : " + a);

            int qaliq;
            int cem = 0;

            while (a>0)
            {
                qaliq = a % 10; //6
                
                a = a / 10;

                cem = cem + qaliq;
            }

            Console.WriteLine("ededin ortada duran reqemlerin cemi : " + cem);

            
        }
    }
}

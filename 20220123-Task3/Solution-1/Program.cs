using System;

namespace Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1) verilmish 4 reqemli ededin reqemlerinin cemini tap

            int a = 1234;
            
            bool dogru = a >= 1000 && a < 10000;

            if (!dogru)
            {
                Console.WriteLine("4 reqemli deyil");

                return;
            }


            int cem =0;
         
            while (a>0)
            {
                int qaliq = a % 10;
                a = a / 10;

                cem = cem + qaliq;
            }
            Console.WriteLine("ededin reqemleri cemi : "+cem);



        }
    }
}

using System;

namespace Solution_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //4) verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati

            int a = 12345;
            bool isSuccess = a >= 10000 && a < 100000;

            if (!isSuccess)
            {
                Console.WriteLine("5 reqemli deyil");
                return;
            }
            Console.WriteLine("ilk ededimiz : " +a);

            int firstNum;
            int lastNum;
            int cem;
            lastNum = a / 10000;
            Console.WriteLine("ilk reqem : " + lastNum);

            firstNum = a % 10;
            Console.WriteLine("son reqem : " + firstNum);

            cem = (lastNum + firstNum)* (lastNum + firstNum);
            Console.WriteLine("kvadratlari cemi : "+cem);




        }
    }
}

using System;

namespace Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2) verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi 
             tap: example: 123600 = 1 + 2 + 3 */

            int a = 345666;

            bool isSuccess = a >= 100000 && a < 1000000;

            if (!isSuccess)
            {
                Console.WriteLine("6 reqemli deyil");
                return;
            }


            int sum = 0;
            a = a / 1000;
            while (a>0)
            {
                int qaliq = a % 10;
                Console.WriteLine(qaliq);
                

                a = a / 10;
                sum = sum + qaliq;
               
            }            
            Console.WriteLine("ilk 3 reqemin ededleri cemi : " + sum);

        }
    }
}

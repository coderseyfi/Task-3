using System;

namespace Solution_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //14) 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
            //6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
            //Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
            //Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
            //Neticenin 60 % tap.Cavabin axirina 60 artir.
            //Neticeden 18 % cix.

            int a = 123456;
            int b = 234567;
            int c = 345678;
            int d = 1234567;
            int a1,b1,c1,d1;// ilk 3 reqem
            double sum; 

            bool dogru = a >= 100000 && a < 1000000 &&
                b >= 100000 && b < 1000000 &&
                c >= 100000 && c < 1000000;
            bool dogru2 = d >= 1000000 && d < 10000000;

            if (!dogru)
            {
                Console.WriteLine("6 reqemli deyil");
                
            }
            if (!dogru2)
            {
               
                Console.WriteLine("7 reqemli deyil");
            }
            a1 = a / 1000; 
            b1 = b / 1000;
            c1 = c / 1000; 
            sum = a1 + b1 + c1;
            d1 = d % 10000;
            sum = sum + d1;

            d = d / 10000; //123
            int qaliq;
            int newN = 1;
            while (d>0)
            {
                qaliq = d % 10; // 3 2 1
                d = d / 10;
                newN = newN * qaliq;
            }
            sum = sum - newN;
            sum = (sum * 60) / 100;
            sum = sum * 1000 + 60;
            sum = sum - (sum * 18) / 100;
            Console.WriteLine("Umumi netice : " +sum);
           

        }
    }
}

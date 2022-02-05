using System;

namespace Solution_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*15)*5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli. 1 denesi 7 reqemli olsun.
             3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
             Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
             Cavabdan 7 reqemli ededin son 5 reqemini cix.
             Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
             Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
             Cavabin axirina 11 artir.
             Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
             Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.*/

            int a = 123;
            int b = 234;
            int c = 123556;
            int d = 234567;
            int e = 1234567;
            int abSum; //a+b
            int abKv; //axirdan 2 denesin kvadrati
            int r3ler; //bir birine yapishdir
            int eSon5;
            int r6lar; //6 reqemlilerin ceminden alinan
            int r7Cem=0; //7 reqemli ededin reqler cemi 
            
            bool dogru1 = a >= 100 && a < 1000 && b >= 100 && b < 1000;
            bool dogru2 = c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000;
            bool dogru3 = e >= 1000000 && e < 10000000;

            if (!dogru1)
            {
                Console.WriteLine("3 reqemli deyil");
            }
            if (!dogru2)
            {
                Console.WriteLine("6 reqemli deyil");
            }
            if (!dogru3)
            {
                Console.WriteLine("7 reqemli deyil");
            }
            
          

            abSum = a + b; //357
            Console.WriteLine(abSum);
            abKv = abSum % 100;
            Console.WriteLine(abKv); //57
            abKv = abKv* abKv;
            Console.WriteLine(abKv); //3249
            r3ler = a * 1000 + b;
            Console.WriteLine(r3ler); //123234
            abKv = abKv + r3ler;
            Console.WriteLine(abKv); //126483
            eSon5 = e % 100000;
            Console.WriteLine(eSon5); //34567;
            abKv = abKv - eSon5;
            Console.WriteLine(abKv); // 91916
            r6lar = c + d;
            Console.WriteLine(r6lar); //358123
            r6lar = r6lar % 1000;
            Console.WriteLine(r6lar); //123
            abKv = abKv + r6lar;
            Console.WriteLine(abKv); //92039
           int yeni7 = e;
            int qaliq;
            while (e>0)
            {
                qaliq = e % 10;
                e = e / 10;
                r7Cem = r7Cem + qaliq;
            }
            Console.WriteLine(r7Cem);
            int qaliq1;
            int yeniR7 = 0;
            while (r7Cem>0)
            {
                qaliq1 = r7Cem % 10;
                r7Cem /= 10;
                yeniR7 = yeniR7 * 10 + qaliq1;

            }
            Console.WriteLine(yeniR7);

            abKv = abKv + yeniR7;
            Console.WriteLine(abKv); //92121
            abKv = abKv * 100 + 11;
            Console.WriteLine(abKv); //9212111


            int qaliq7;
            int counter = 1;
            int tek_reqem7 = 0;
            while (yeni7 > 0)
            {
                qaliq7 = yeni7 % 10;
                yeni7 = yeni7 / 10;

                if (counter % 2 != 0)
                {
                    tek_reqem7 = tek_reqem7 * 10 + qaliq7;
                }
                counter++;
            }
            Console.WriteLine(tek_reqem7);

            int qaliq6;
            int ters7=0;
            while (tek_reqem7>0)
            {
                qaliq6 = tek_reqem7 % 10;
                tek_reqem7 /= 10;
                ters7 = ters7 * 10 + qaliq6;
            }
            Console.WriteLine(ters7);

            abKv = abKv - ters7;
            Console.WriteLine(abKv);
            abKv = abKv / 10;
            abKv = abKv * 100 + 88;
            abKv = abKv * 10 + 4;
            Console.WriteLine("yekunda alinan netice 88 ededini son 2 reqemin arasina qoy : " +abKv);
        }
    }
}

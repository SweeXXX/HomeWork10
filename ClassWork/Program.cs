using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "-----\n-   -\n-   -\n-----";
            string str1 = "123\n123\n123";
            str = str.Replace("-", "*");
            Figure f = new Figure(str);
            Figure f2 = new Figure(str1);
            f2.PrintNew(10);
            f.PrintStart();
            
            Console.ReadKey();
            f.PrintNew(18, 10);
            f2.PrintNew(12,15);
            
            //f.PrintVertical();
        }
    }
}
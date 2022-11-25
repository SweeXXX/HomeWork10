using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public enum Visibale
    {
        Yes = 0,
        No = 1
    }
    public class Figure
    {
        protected ConsoleColor color;
        protected Visibale Visibale;
        protected string figure;
        public Figure(string figure, ConsoleColor color, Visibale visibale)
        {
            this.figure = figure;
            this.color = color;
            this.Visibale = visibale;
        }
        public Figure(string figure)
        {
            this.figure = figure;
        }
        public string GetFigure
        {
            get { return figure; }
            set { figure = value; }
        }
        public void PrintStart()
        {
            //Console.Clear();
            int i1 = 0; int i2 = 0;
            Console.CursorLeft = i1;
            Console.CursorTop = i2;
            Console.WriteLine(figure);
        }
        //public void PrintVertical(int n=10)
        //{
        //    Console.Clear();
        //    int i1 = 0; int i2 = n;
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.CursorLeft = i1;
        //    Console.CursorTop = i2;
        //    for(int i =0; i<figure.Length-1; i++)
        //    {
        //        if($"{figure[i]}{figure[i+1]}" == "\n" )
        //        {
        //            Console.Write("\n");
        //            for(int j = 0; j < i2; j++)
        //            {
        //                Console.Write(" ");
        //            }
        //        }
        //        else
        //        {
        //            Console.Write(figure[i]);
        //        }
        //    }
        //    Console.Write(figure[figure.Length-1]);
        //}
        public void PrintNew(int n1 = 10, int n2 = 0, ConsoleColor s2 = ConsoleColor.White)
        {
            try
            {
                //Console.Clear();
                int i1 = n1; int i2 = n2;
                Console.ForegroundColor = s2;
                Console.CursorLeft = i1;
                Console.CursorTop = i2;
                for (int i = 0; i < figure.Length - 1; i++)
                {
                    if ($"{figure[i]}" == "\n")
                    {
                        Console.Write("\n");
                        for (int j = 0; j < i1; j++)
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(figure[i]);
                    }
                }
                Console.Write(figure[figure.Length - 1]);
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }
        }

    }


}

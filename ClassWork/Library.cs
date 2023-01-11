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
        protected Figure()
        { }
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
        public void PrintNew(int n1 = 10, int n2 = 0, ConsoleColor s2 = ConsoleColor.White, ConsoleColor s1 = ConsoleColor.Black, bool bl=true)
        {
            try
            {
                Console.ForegroundColor = s2;
                Console.BackgroundColor = s1;
                if (bl)
                    Console.Clear();

                int i1 = n1; int i2 = n2;
                
                Console.CursorLeft = i1;
                Console.CursorTop = i2;
                if(s1==s2)
                    Visibale = Visibale.No;
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
        public void PrintNew(bool Visibale, int n1 = 10, int n2 = 0)
        {
            try
            {
                //Console.Clear();
                int i1 = n1; int i2 = n2;
                if(!Visibale)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Visibale visibale = Class.Visibale.Yes;
                }
                Console.CursorLeft = i1;
                Console.CursorTop = i2;
                for (int i = 0; i < figure.Length - 1; i++)
                {
                    if ($"{figure[i]}" == "\n")
                    {
                        Console.Write("\n");
                        Console.CursorLeft = i1;
                        i2++;
                        Console.CursorTop = i2;
                    }
                    else
                    {
                        Console.Write(figure[i]);
                    }
                }
                Console.Write(figure[figure.Length - 1]);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
        
        public void Vivod()
        {
            Console.WriteLine($"Цвет:{color}\nВидимость: {Visibale}\nФигура: {figure}");
        }
    }
    class Point:Figure
    {
        public Point()
        {
            this.figure = "*";
        }
        public Point(char chr)
        {
            this.figure = chr.ToString();
        }
    }
    class Circle:Point
    {
        double R;
        public Circle( double r)
        {
            R = r;
        }
        public double FindS()
        {
            return 2*Math.PI*Math.Pow(R, 2);
        }
        public static double FindS(double R)
        {
            return 2 * Math.PI * Math.Pow(R, 2);
        }
    }
    class Rectangle : Point
    {
        double width;
        double length;
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
            figure = "*****\n*   *\n*   *\n*****";
        }
        public Rectangle(double width, double length, string figure)
        {
            this.width = width;
            this.length = length;
            this.figure = figure;
        }
        public double GetLength
        { get { return length; } }
        public double GetWidth
            { get { return width; } }
        public static double FindS(double w, double l)
        {
            return w * l;
        }
        public double FindS()
        {
            return width * length;
        }
    }
}

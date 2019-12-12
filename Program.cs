using System;

namespace ConsoleApp2
{
    class Program
    {
        static public void FindMinSquare(int a,int b)
        {
            int x = 1;
            int y = 0;
            double minsquare = double.MaxValue;
            int min_x=0;
            int min_y=0;
            while (x <=Math.Abs(a)+1 && y <=Math.Abs(b)+1)
            {
                double S = FindSquareByPoints(Math.Abs(a), Math.Abs(b), x, y);
                //Console.WriteLine("C({0};{1})     S={2}", x, y, S);
                if (S <= minsquare && S>0)
                {
                    minsquare = S;
                    min_x = a != Math.Abs(a) ? -x : x;
                    min_y = b != Math.Abs(b) ? -y : y;
                }

                if (x == Math.Abs(a)+1)
                {
                    x = 0;
                    y++;
                }
                else
                {
                    x++;
                }

                if (x == Math.Abs(a)+1 && y == Math.Abs(b)+1) { Console.WriteLine("При координатах точки С({0};{1}) мінімальна площа дорівнює {2}", min_x, min_y, minsquare); }
            }
        }
        static double FindSquareByPoints(int a, int b,int x, int y)
        {
             double S = (Math.Abs((Math.Abs(a) * y) - (Math.Abs(b) * x))) / 2.0; 
             return S;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть першу координату точки В");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть другу координату точки В");
            int b = int.Parse(Console.ReadLine());
            FindMinSquare(a,b);
        }
    }
}

using System;

namespace Minimum_of_10_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple

            /*
            int a, b, c, d, e, f, g, h, i, j;
            int Minimum = 9999;

            Console.Write("Enter Number 1  : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 2  : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 3  : ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 4  : ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 5  : ");
            e = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 6  : ");
            f = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 7  : ");
            g = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 8  : ");
            h = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 9  : ");
            i = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 10 : ");
            j = int.Parse(Console.ReadLine());

            if (a < Minimum) Minimum = a;
            if (b < Minimum) Minimum = b;
            if (c < Minimum) Minimum = c;
            if (d < Minimum) Minimum = d;
            if (e < Minimum) Minimum = e;
            if (f < Minimum) Minimum = f;
            if (g < Minimum) Minimum = g;
            if (h < Minimum) Minimum = h;
            if (i < Minimum) Minimum = i;
            if (j < Minimum) Minimum = j;

            Console.WriteLine($"\nMinimum : {Minimum}");
            Console.ReadKey();
            */

            //Medium
            /*
            int[] arrayNumber = new int[10];
            int Minimum = 9999;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter Number {i+1} : ");
                arrayNumber[i] = int.Parse(Console.ReadLine());
                if (arrayNumber[i] < Minimum) Minimum = arrayNumber[i];
            }

            Console.WriteLine($"\nMinimum : {Minimum}");
            Console.ReadKey();
            */

            //Hard
            /*
            int[] arrayNumber = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter Number {i + 1} : ");
                arrayNumber[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nMinimum : {MinimumFunction(arrayNumber)}");
            Console.ReadKey();
            */
        }

        static int MinimumFunction(int[] arrayNumber)
        {
            int min = 9999;
            for (int i = 0; i < 10; i++)
            {
                if (arrayNumber[i] < min)
                    min = arrayNumber[i];
            }
            return min;
            
        }
    }
}

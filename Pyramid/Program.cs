using System;

namespace Pyramid
{
    class Program
    {
        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(" ");
                }
                for (int y = 1; y <= 2 * i - 1; y += 1)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my draw a pyramid console application");
            Console.Write("please enter a Number:");
            int userinput = Convert.ToInt32(Console.ReadLine());
            DrawPyramid(userinput); 
        }
    }
}

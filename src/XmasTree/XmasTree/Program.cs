using System;

namespace XmasTree
{
    class Program
    {
        static void Main()
        {
            int n = 8;

            for (int i = 1, l = (n + 1) * n * 2; i < l; i++)
                Console.Write(i % (n * 2) == 0 ? "\n"
                    : (i / (n * 2) == n ? ((i - i / (n * 2) * n * 2 == n) ? "I" : " ")
                    : (i - i / (n * 2) * n * 2 < n - i / (n * 2) ? " "
                    : (i - i / (n * 2) * n * 2 < n + i / (n * 2) + 1) ? "X" : "")));
            Console.ReadLine();
        }
    }
}
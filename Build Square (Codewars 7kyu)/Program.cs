using System;

namespace Build_Square__Codewars_7kyu_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(GenerateShape(n));
        }

        public static string GenerateShape(int n)
        {
            string pattern = "";
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    pattern += "+";
                }
                if (row < n - 1)
                {
                    pattern += "\n";
                }

            }
            return pattern;
        }
    }
}

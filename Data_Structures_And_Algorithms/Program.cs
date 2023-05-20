using System;

namespace Data_Structures_And_Algorithms
{
    class Program
    {
        static void permute(string str, int sI, int eI)
        {
            if (sI == eI)
                Console.WriteLine(str);
            else
            {
                for (int i = sI; i <= eI; i++)
                {
                    str = swap(str, sI, i);
                    permute(str, sI + 1, eI);
                    str = swap(str, sI, i);
                }
            }
        }

        public static string swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures and Algorithms Practice Problems!");
            Console.WriteLine("Program of Permutations of a String!");
            Console.WriteLine("\nEnter any no of alphabets:");
            string str = Console.ReadLine();
            Console.WriteLine("All possible permutations of a string: {0}", str);
            int n = str.Length;
            permute(str, 0, n - 1);
        }
    }
}
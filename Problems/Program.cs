using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(prefix(Hello));
        }

        public string Prefix(string input)
        {
            int length = 0;
            string[] words = input.Split(" ");
            for (int n =0; n < input.Length;n++)
            {
                length++;
            }
            return $"{length},{words.Length}:{input} ";
        }
    }
   
   
}

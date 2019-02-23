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
            string[] words = input.Split(" ");
            int WordCount =0;
            foreach (string s in words){
                if (!(s == "" || s== " ")){
                    WordCount++;
                }
            }
            return $"{input.Length},{WordCount}:{input}";
        }
    }
   
   
}

using System;

namespace CountingCharacters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string
            value = "def";
            foreach (char e in value)
            {
                Console.WriteLine(e);
            }
            Dictionary<char, int> diclist = new Dictionary<char, int>();
            Console.WriteLine("Enter character string");

            foreach (var chr in Console.ReadLine())
            {
                int count = 0;
                if (diclist.ContainsKey(chr))
                {
                    count = diclist[chr];
                }
                diclist[chr] = count + 1;
            }
                foreach (KeyValuePair<char, int> pair in diclist)
                {
                    Console.WriteLine(pair.Key + " = " + pair.Value);
                }
                Console.ReadLine();
        }
    }
}
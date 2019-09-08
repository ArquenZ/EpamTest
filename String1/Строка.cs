using System;
using System.Collections.Generic;

namespace String1
{
    class Program
    {       
        static List<string> Unique(string text)//создает список неповторяющихся слов
        {
            List<string> words = new List<string>();
            string nodots = text.Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "").Replace("-", "").Trim();
            string[] a1 = nodots.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string a in a1)
            {

                int i = 0, count = 0;
                while (i < a1.Length)
                {
                    if (a.ToUpper() == a1[i].ToUpper())
                    {
                        count++;
                    }
                    i++;
                }
                if (count <2)
                {
                    words.Add(a);
                }
            }
            return words;
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();            
            foreach (string b in Unique(text))
            {
                Console.WriteLine(b);
            }
        }
    }
}

using System;

namespace Скобки
{
    class Program
    {       
        private static bool Scob(string s)
        {
            int last = s.Length;
            s = s.Replace("[]", "").Replace("()", "").Replace("{}","");
            Console.WriteLine(s);//Для наглядности работы метода

            if (s.Length == 0)
            {
                return true;
            }
            else if (last == s.Length)
            {
                return false;
            }
            else
            {
                return Scob(s);
            }
        }

        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine(Scob(a));
        }
    }
}

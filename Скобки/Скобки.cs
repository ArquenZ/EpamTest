using System;

namespace Скобки
{
    class Program
    {

        //static bool Scob(string a)
        //{
        //    if (a.Length % 2 != 0)
        //    {
        //        return false;
        //    }
        //    int count = 0;
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] == '(')
        //        {
        //            count++;
        //        }
        //        else
        //        {
        //            count--;
        //        }
        //        if (count < 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        private static bool Scob(string s)
        {
            int last = s.Length;
            s = s.Replace("[]", "").Replace("()", "").Replace("{}","");
            //Console.WriteLine(s);//Для наглядности работы метода

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

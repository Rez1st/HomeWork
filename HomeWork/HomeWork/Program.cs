using System;
using System.Text;

namespace HomeWork
{
    public class Program
    {
        public delegate int Add(int x, int y);

        public delegate string GetVeryLongString(int length);

        static void Main(string[] args)
        {
            int count = 200000000;

            var getStringSb = new GetVeryLongString(GetStringWithSimpleConcat);
            var getStringConcat = new GetVeryLongString(GetStringWithStringBuilder);

            getStringSb(count);
            getStringConcat(count);
        }

        public static string GetStringWithStringBuilder(int length)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(i);
            }

            return sb.ToString();
        }

        public static string GetStringWithSimpleConcat(int length)
        {
            string s = String.Empty;
            for (int i = 0; i < length; i++)
            {
                s += i;
            }

            return s;
        }
    }
}
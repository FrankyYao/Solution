using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JianDaTi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestSubString(""));
        }

        public static int LongestSubString(string s)
        {
            if (s.Length <= 0) return 0;
            Hashtable hs = new Hashtable();
            char[] c = s.ToArray();
            int maxLength = 0, count = 0;
            for (int i = 0;i < c.Length; i++)
            {
                if (!hs.Contains(c[i]))
                {
                    hs.Add(c[i], true);
                    count++;
                }
                else
                {
                    maxLength = Math.Max(maxLength, count);
                    count = 1;
                    hs.Clear();
                    hs.Add(c[i], true);
                }
            }
            return maxLength;
        }
    }
}

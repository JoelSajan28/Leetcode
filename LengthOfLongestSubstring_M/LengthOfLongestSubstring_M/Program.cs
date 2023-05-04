using System;
using System.Collections.Generic;
using System.Linq;

namespace LengthOfLongestSubstring_M
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
        }

        public static int LengthOfLongestSubstring(string bigchunck)
        {
            if (string.IsNullOrWhiteSpace(bigchunck))
            {
                return bigchunck.Select(x => x).ToArray().Length > 0 ? 1 : 0;
            }
            var smallchops = bigchunck.Select(x => x).ToArray();
            string gainer = string.Empty;
            Queue<string> gainers = new Queue<string>();
            foreach (char chop in smallchops)
            {
                if (gainer.Contains(chop))
                {
                    gainers.Enqueue(gainer);
                    var whereischop = gainer.IndexOf(chop)+1;
                    gainer = whereischop == gainer.Length ? chop.ToString() : gainer.Substring(whereischop, gainer.Length - whereischop) + chop.ToString();
                }
                else
                {
                    gainer = gainer + chop.ToString();
                }
            }
            gainers.Enqueue(!string.IsNullOrEmpty(gainer) ? gainer:""); 
            return gainers.Max(x=>x.Length);
        }
    }
}

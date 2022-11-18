using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAddBinary
{
    internal class Program
    {
        public class Solution
        {
            public string AddBinary(string a, string b)
            {
                return a + b;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.AddBinary("1110", "1000111"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAddBinary
{
    public class Adder
    {
        public string AddBinary(string a, string b)
        {

            char[] ret = new char[(a.Length > b.Length ? a.Length : b.Length)+ 1];
            byte sum = 0;
            for (int i = 0; i < ret.Length; i++)
            {
                int aIndex = a.Length - i - 1;
                int bIndex = b.Length - i - 1;
                sum = (byte)(
                    (aIndex >= 0 && a[aIndex] == '1' ? 1 : 0)
                    + (bIndex >= 0 && b[bIndex] == '1' ? 1 : 0)
                    + sum
                            );
                ret[ret.Length - i - 1] = (sum % 2 == 1 ? '1' : '0');
                sum = (byte)(sum / 2);

            }
            if (ret.All(c => c == '0')) return "0";
            return (new string(ret)).TrimStart('0');
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Adder s = new Adder();
            Console.WriteLine(s.AddBinary("1", "1"));
            Console.ReadLine();

        }
    }
}

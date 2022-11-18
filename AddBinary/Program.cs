using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NAddBinary
{
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

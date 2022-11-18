using System.Linq;

namespace NNeedleHaystackFinder
{
    public class NeedleHaystackFinder 
    {
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length-needle.Length; i++) 
            {
                int  j= 0;
                for (j = 0; j < needle.Length; ) 
                {
                    if (haystack[i + j] != needle[j]) break;
                    j++;
                }
                if(j== needle.Length) return i;
                
            }
            return -1;
        }
    }
}

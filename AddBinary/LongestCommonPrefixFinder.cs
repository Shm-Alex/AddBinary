namespace NLongestCommonPrefixFinder
{
    public class LongestCommonPrefixFinder
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if ((strs == null)|| (strs.Length < 1)) return "";
            //if (strs.Length==1) return strs[0];

            for (int prefixLength = 0; prefixLength < strs[0].Length; prefixLength++) 
            {
                for (int scanWordsIndex = 1; scanWordsIndex < strs.Length; scanWordsIndex++) 
                {
                    if ((strs[scanWordsIndex].Length<= prefixLength) ||(strs[scanWordsIndex][prefixLength] != strs[0][prefixLength])) 
                    { if (prefixLength > 0) return strs[0].Substring(0, prefixLength);
                            return "";
                    }
                }
            
            }
            return strs[0];
        }
    }
}

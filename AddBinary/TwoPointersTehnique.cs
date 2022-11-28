namespace NTwoPointersTehnique
{
    public class TwoPointersTehnique 
    {
        public void ReverseString(char[] s)
        {
            int left = 0, right = s.Length - 1;
            
            while (left < right) 
            {
                char swap = s[left];
                s[left] = s[right];
                s[right] = swap;    
                left++;
                right--;
            
            }

        }
    }
}

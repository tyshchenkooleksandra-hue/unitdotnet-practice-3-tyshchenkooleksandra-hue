using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_DotNet_Practics3
{
    public class StringReverser
    {
        public string ReverseString(string s)
        {
            char[] chars = s.ToCharArray();

            int left = 0;
            int right = chars.Length - 1;

            while (left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
            }

            return new string(chars);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_DotNet_Practics3
{
    public class VowelCounter
    {
        public int CountVowels(string input)
        {
            int count = 0;

            foreach (char c in input.ToLower())
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++;
                }
            }

            return count;
        }
    }
}

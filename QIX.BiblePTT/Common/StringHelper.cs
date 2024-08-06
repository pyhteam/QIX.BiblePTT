using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QIX.BiblePTT.Common
{
    public static class StringHelper
    {
        public static List<string> SmartSplit(string input, int maxLength)
        {
            var result = new List<string>();
            int currentIndex = 0;

            while (currentIndex < input.Length)
            {
                int lengthToTake = Math.Min(maxLength, input.Length - currentIndex);
                string part = input.Substring(currentIndex, lengthToTake);

                if (currentIndex + lengthToTake < input.Length && !char.IsWhiteSpace(input[currentIndex + lengthToTake]))
                {
                    int lastSpaceIndex = part.LastIndexOf(' ');
                    if (lastSpaceIndex > -1)
                    {
                        lengthToTake = lastSpaceIndex + 1;
                        part = input.Substring(currentIndex, lengthToTake).Trim();
                    }
                }

                result.Add(part);
                currentIndex += lengthToTake;
            }

            return result;
        }
    }
}
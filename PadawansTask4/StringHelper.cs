using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            if(str == null)
                            throw new ArgumentNullException();

            if (str == "")

                throw new ArgumentException();

            int count = 0;
            string letters = "aAiIoOeEuU";
            for (int i = 0; i < str.Length; i++)
                for (int j = 0; j < letters.Length; j++)
                    if (str[i] == letters[j])
                        count++;

            return count;

        }
    }
}

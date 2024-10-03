using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class StringExtensions1
{
    public static int CountWordsWithSameStartAndEnd(this string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            return 0;
        }

        string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        foreach (var word in words)
        {
            if (word.Length > 1 && char.ToLower(word[0]) == char.ToLower(word[^1]))
            {
                count++;
            }
        }
        return count;
    }
}

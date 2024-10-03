using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class StringExtensions
{
    public static int SentenceCount(this string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            return 0;
        }

        string[] sentences = str.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return sentences.Length;
    }
}
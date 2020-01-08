using System;
namespace CSharpPlayground
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            string[] words = phrase.Split();
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
            return String.Join(" ", words);
        }
    }
}

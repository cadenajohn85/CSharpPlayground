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
                Console.WriteLine(words[i]);
            }
            return String.Join(" ", words);
        }

        public static void Main(string[] args)
        {
            ToJadenCase("blah di dah");
        }
    }
}

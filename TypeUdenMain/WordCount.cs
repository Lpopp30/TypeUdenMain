using System;
using System.Collections.Generic;
using System.Text;

namespace TypeUdenMain
{
    internal class WordCount
    {
        public static int CountWords(string word, string text)
        {
            if (string.IsNullOrEmpty(word) || string.IsNullOrEmpty(text))
                return 0;

            word = word.ToLower();
            text = text.ToLower();

            int count = 0;
            for (int i = 0; i + word.Length <= text.Length; i++)
            {
                int j = 0;
                while (j < word.Length && text[i + j] == word[j]) j++;
                if (j == word.Length) count++;
            }

            return count;
        }

        public static bool? TrueOrFalse(int count, string word, string Text)
        {
            if (count == 0)
                return null;
            
            else if (count >= 1 && count <= 10)
                return false;

            else
                return true;
            
        }

        public static string SaveToFile(string filePath, string text)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                string projectFolder = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName;

                filePath = Path.Combine(projectFolder, "log.txt");

            }
            


            File.WriteAllText(filePath, text);
            return filePath;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TypeUdenMain
{
    internal class WordCount
    {
        public static int CountWords(string word, string text)
        {
            if (string.IsNullOrEmpty(word) || string.IsNullOrEmpty(text))
            {
                return 0;
            }

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

        public static Result<bool> TrueOrFalse(int count, string word, string Text)
        {
            if (count == 0)
            {
                if (string.IsNullOrEmpty(word) && string.IsNullOrEmpty(Text))
                {
                    return Result<bool>.Failure("Du har ikke indtastet et ord og en tekst");
                }
                if (string.IsNullOrEmpty(word))
                {
                    return Result<bool>.Failure("Du har ikke indtastet et ord");
                }

                if (string.IsNullOrEmpty(Text))
                {
                    return Result<bool>.Failure("Du har ikke indtastet en tekst");
                }

                return Result<bool>.Failure("Ordet blev ikke fundet i teksten");
            }

            if (count >= 1 && count <= 10)
                return Result<bool>.Success(false);

            return Result<bool>.Success(true);
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

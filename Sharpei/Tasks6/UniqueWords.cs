using System;
using System.Collections.Generic;

public static class UniqueWords
{
    public static List<string> GetUniqueWords(string text)
    {
        text.ToLower();
        string[] words = text.Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
        var uniqueWords = new List<string>();
        foreach (string word in words)
        {
            if (uniqueWords.Count == 0)
            {
                uniqueWords.Add(word);
                continue;
            }
            var i = 0;
            for (; i < uniqueWords.Count; i++)
                if (word == uniqueWords[i]) break;
            if (i == uniqueWords.Count) uniqueWords.Add(word);
        }
        return uniqueWords;
    }
}


                        
        

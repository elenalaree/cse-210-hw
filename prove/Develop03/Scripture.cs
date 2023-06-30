using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    Reference   reference;
    List<Word>  words;
    static Random random = new Random();

    public Scripture( Reference _reference, string _text)
    {
        reference = _reference;
        words = new List<Word>();

        List<string> allwords = _text.Split(' ').ToList();
        foreach(string wordString in allwords)
        {
            Word newWord = new Word(wordString);
            words.Add(newWord);
        }
    }

    public void HideRandomWords()
    {
        int hidden_words = 0;
        do
        {
            int randIndex = random.Next(words.Count);
            if(!words[randIndex].GetIsHidden())
            {
            words[randIndex].HideThis();
            hidden_words ++;
            }
        }
        while((hidden_words < 2) && (!IsCompletelyHidden()));

    }

        public void ShowRandomWords()
    {
        int shown_words = 0;
        do
        {
            int randIndex = random.Next(words.Count);
            if(words[randIndex].GetIsHidden())
            {
            words[randIndex].ShowThis();
            shown_words ++;
            }
        }
        while(shown_words < 2 && (!IsCompletelyShown()));

    }
    public string GetDisplayText()
    {
        string scriptureText = "";

        foreach(Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                scriptureText += word.GetDisplayText() + " ";
            }
            else{
                scriptureText += new string('_', word.GetDisplayText().Length) + " ";
            }
        }
        string reference_text = reference.GetDisplayText();

        return $"{reference_text} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        int hidden_count = 0;
        foreach(Word word in words)
            if (word.GetIsHidden() == true)
            {
                hidden_count++;
            }
        if (hidden_count == words.Count)
        {
            return true;
        }
        else{
            return false;
        }

        
    }

        public bool IsCompletelyShown()
    {
        int shown_count = 0;
        foreach(Word word in words)
            if (word.GetIsHidden() == false)
            {
                shown_count++;
            }
        if (shown_count == words.Count)
        {
            return true;
        }
        else{
            return false;
        }

        
    }
}


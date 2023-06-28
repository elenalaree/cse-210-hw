using System;

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
        HideRandomWords();
        foreach(string wordString in allwords)
        {
            Word newWord = new Word(wordString);
            words.Add(newWord);
        }
    }

    public void HideRandomWords()
    {
        List<int> selected = new List<int>();
        int randIndex = -1;
        do
        {
        randIndex = random.Next(list.Count);
        selected.Add(randIndex);
        string randomNumber = list[randIndex];
        
        }
        while(selected.Contains(randIndex) == false);
        Console.WriteLine("We got out.");

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

        return ($"{reference} {scriptureText}");
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}


using System;

class Word
{
    string text;

    bool IsHidden;

    public Word(string _text)
    {
        text = _text;
    }

    public void HideThis()
    {
        IsHidden = true;
    }

    public void ShowThis()
    {
        IsHidden = false;
    }

    public bool GetIsHidden()
    {
        return IsHidden;
    }
    
    public string GetDisplayText()
    {

        return text;
    }
}
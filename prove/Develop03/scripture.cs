using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

class Scripture
{
    private Reference _reference;
    private List<Word> _text;
    public Scripture(string scripture) {
        _text = new List<Word>();
        string[] scriptureSplit = scripture.Split('|');
        List<string> scriptureContent = scriptureSplit.ToList();
        _reference = new Reference(scriptureContent[0], int.Parse(scriptureContent[1]), int.Parse(scriptureContent[2]), int.Parse(scriptureContent[3]));
        for (int i = 5; i > 0; i--)
        {
            scriptureContent.RemoveAt(0);
        }
        foreach (string item in scriptureContent)
        {
            Word word = new Word(item);
            _text.Add(word);
        }
        
    }
    public string GetDisplayString()
    {
        // return textString;
        string displayString = _reference.GetReference();
        
        foreach (Word word in _text)
        {
            displayString += word.GetWord();
            displayString += " ";
        }
        return displayString;
    }
    public void HideAWord()
    {
        List<Word> unhiddenWords = new();
        foreach (Word word in _text)
        {
            if (!word.GetIsHidden())
            {
                unhiddenWords.Add(word);
            }
        }
        Random rand = new();
        if (unhiddenWords.Count() > 0)
        {
            int wordIndex = rand.Next(unhiddenWords.Count());
            unhiddenWords[wordIndex].HideWord();
        }
    }
    public void ShowWords()
    {
        foreach (Word word in _text)
            {
                word.ShowWord();
            }
    }
    public bool AnyUnhidden()
    {
        bool anyUnhidden = false;
        foreach (Word word in _text)
        {
            if (!word.GetIsHidden())
            {
                anyUnhidden = true;
            }
        }
        return anyUnhidden;
    }
}
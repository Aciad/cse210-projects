class Word
{
    private string _word;
    private bool _hidden;
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    public string GetWord()
    {
        if (_hidden == true)
        {
            string hiddenWord = "";
            // for (int i = _word.Length; i <= 1; i--)
            // {
            //     hiddenWord += "-";
            // }
            // // Console.WriteLine(hiddenWord);
            foreach (Char letter in _word) {
                hiddenWord += "_";
            }
            return hiddenWord;
        }
        else
        {
            return _word;
        }
    }
    public bool GetIsHidden()
    {
        return _hidden;
    }
    public void HideWord()
    {
        _hidden = true;
    }
    public void ShowWord()
    {
        _hidden = false;
    }
}
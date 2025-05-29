
class WordCounter
{
    private List<string> _words;

    public WordCounter(string text)
    {
        _words = new List<string>();
    }

    private void SplitTextIntoWords(string text)
    {
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _words.Add(word);
        }
    }


}
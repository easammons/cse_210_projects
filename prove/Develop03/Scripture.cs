

public class Scripture
{
    private List<Word> words;
    private Random random;

    public Scripture(Reference reference)
    {
        random = new Random();
        words = SplitIntoWords(reference.Text);
    }

    public List<Word> GetWords()
    {
        return words;
    }

    private List<Word> SplitIntoWords(string text)
    {
        char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r', '\t' };

        List<string> splitWords = text
            .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        return splitWords.Select(word => new Word(word)).ToList();

    }

    public void HideRandomWords(int count = 3)
    {
        var candidates = words.Where(w => !w.IsHidden).ToList();

        if (candidates.Count == 0) return;

        int hideCount = Math.Min(count, candidates.Count);

        for (int i = 0; i < hideCount; i++)
        {
            int index = random.Next(candidates.Count);
            candidates[index].Hide();
            candidates.RemoveAt(index);
        }
    }

    // Join the words back into a single string with spaces
    public string GetText()
    {
        // Just join the DisplayText of each word with spaces
        return string.Join(" ", words.Select(w => w.DisplayText));
    }

    public bool AreAllWordsHidden()
    {
        return words.All(w => w.IsHidden);
    }
        
        
}


using System.Runtime.CompilerServices;

public class Word
{
    public string Text { get; private set; }
    private bool isHidden;

    public Word(string text)
    {
        Text = text;
        isHidden = false;
    }

    public void Hide()
    {
        if (!isHidden)
        {
            Text = new string('_', Text.Length);
            isHidden = true;
        }
    }

    public bool IsHidden => isHidden;

    public string DisplayText => isHidden ? Text : Text;
}
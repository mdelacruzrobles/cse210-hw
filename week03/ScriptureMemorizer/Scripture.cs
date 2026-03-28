using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    Reference reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        string[] wordsArray = text.Split(" ");
        foreach (string w in wordsArray)
        {
            Word wordObjects = new Word(w);
            _words.Add(wordObjects);
        }
        

    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
        while (hiddenCount< numberToHide)
        {
            int randomIndex = random.Next(_words.Count);
            Word hiddenWord = _words[randomIndex];
            if (hiddenWord.isHidden() != true)
            {
                hiddenWord.Hide();
                hiddenCount ++; 
            }
            if (isCompletelyHidden())
            {
                break;
            }
        }

    }
    public string GetDisplayText()
    {
        string result = reference.GetDisplayText() + "";
        foreach (Word w in _words)
        {
            result += w.GetDisplayText() + " ";
        }
        return result;
    }
    public bool isCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if(!w.isHidden())
            {
                return false;
            }
        }
        return true;
    }
}
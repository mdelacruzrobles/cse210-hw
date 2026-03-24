using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach(Entry e in _entries)
        {
            e.Display();
        }
    }
    public void SaveToFile(string file)
    {
        List<string> lines = new List<string>();
        foreach (Entry e in _entries)
        {
            lines.Add(e.ToFileString());
        }
        File.WriteAllLines(file, lines);
    }
    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);
        _entries.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry e = new Entry();
            e._date = parts[0];
            e._promptText = parts[1];
            e._entryText = parts[2];

            _entries.Add(e);
        }
    }
}
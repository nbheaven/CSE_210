class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    } 

    public void DisplayEntries()
    {
        foreach (Entry item in _entries)
        {
            Console.WriteLine(item);
        }
    }

    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {          
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }

    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            Entry entry = new Entry();  
            this.AddEntry(entry);
        }
    }
}
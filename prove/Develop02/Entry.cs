class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string Content { get; set; }

    public void JournalEntry()
    {
        Content = ($"{_date} {_prompt} {_response}");
    }

    public override string ToString()
    {
        string outputString = "";

        outputString = $"{_date}#{_prompt}#{_response}";

        return outputString;
    }

}
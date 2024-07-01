class Menu
{
    public string _menuItem;
    Questions prompt1 = new Questions();
    Entry entry1 = new Entry();

    Journal journal1 = new Journal();

     public void DisplayTitle()
    {
        Console.WriteLine("Welcome to Journaling program, Please select an option.");
    }

    public void ProcessMenu()
    
    {
       do
        {
            Console.WriteLine("\n1. Make New Entry\n2. Display Previous Entries\n3. Save Current entry\n4. Load Journal from file");
            _menuItem = Console.ReadLine().ToUpper();
            
            if (_menuItem == "1") //Collects data for jourlan entry and converts it to a string and appends it to the journal list
            {
                prompt1._activeQuestion = prompt1.RandomQuestion();
                entry1._date = $"{DateTime.Now}";
                entry1._prompt = prompt1._activeQuestion;
                Console.WriteLine($"{entry1._prompt} Please write your response below.\n");
                entry1._response = Console.ReadLine();
                journal1.AddEntry(entry1);
            }
            else if (_menuItem == "2")
            {
                journal1.DisplayEntries();
            }
            else if (_menuItem == "3")
            {
                Console.WriteLine("What is the name of the journal file?");
                string file = Console.ReadLine();
                journal1.WriteToFile(file);
            }
            else if (_menuItem == "4")
            {
                Console.WriteLine("What is the name of the journal file?");
                string file1 = Console.ReadLine();
                journal1.ReadFromFile(file1);
            }
            else if (_menuItem == "EXIT")
            {
                Console.WriteLine("Thank you for journaling");
            }
            else
            {
                Console.WriteLine("INVALID OPTION");
            }
        } while (_menuItem != "EXIT");

    }
}
public class Questions
{
    private List<string> _questions;
    public string _activeQuestion;

    public Questions()
    {
        _questions = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did I accomplish today that I am proud of?",
            "What is one thing I learned today?",
            "How did I help someone today?",
            "What challenge did I overcome today?",
            "What was the most surprising thing that happened today?"
        };
    }

    public string RandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }
}
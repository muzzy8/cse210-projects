public abstract class Goal
{
    string _title;
    string _description;
    protected int _endAward = 0;
    protected int _progressAward;
    protected bool _isComplete;
    string _goalSummary;

    public abstract int Award();
    
    public abstract void Create(); // this may be useless because of contructers 

    public void PromptTitleAndDescription()
    {
        Console.Write("Goal Title: ");
        _title = Console.ReadLine();
        Console.Write("Description: ");
        _description = Console.ReadLine();
    }

    public abstract void Display();

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    void setIsComplete(bool isComplete)
    { // sets _isComplete
        _isComplete = isComplete;
    }

    // public List<string> GetGoalsString()
    // {
    //     List <string> goalsString = new List<string>();
    //     return goalsString;
    // }

    public string BuildGoalSummary()
    {
        string delimited = $"{_title},{_description},{_endAward},{_progressAward},{_isComplete}";
        SetGoalSummary(delimited);
        return delimited;
    }

    public void SetGoalSummary(string goalSummary)
    {
        _goalSummary = goalSummary;
    }

    public string GetGoalSummary()
    {
        return _goalSummary;
    }
}
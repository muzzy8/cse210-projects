class Session
{
    string _score;
    string _sessionSummary;
    List<string> _sessionSummaryList;
    List<Goal> _goals;

    public Session()
    {

    }

    public Session(int score, List<Goal> goals)
    {
        _score = score.ToString();
        _goals = goals;
    }

    void BuildSessionSummary()
    {
        string sessionSummary = "";
        foreach (Goal singleGoal in _goals)
        {
            string singleGoalSummary = singleGoal.BuildGoalSummary();
            sessionSummary += "\n" + singleGoalSummary;
        }
        sessionSummary += "\n" + _score;
        _sessionSummary = sessionSummary;
    }

    public string GetSessionSummary()
    {
        return _sessionSummary;
    }
}
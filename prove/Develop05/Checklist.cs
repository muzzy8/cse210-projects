class Checklist : Goal
{
    // _endValue
    // _progressValue;
    // _isComplete
    int _currentProgress;
    int _maxProgress;

    public Checklist() : base()
    {
        Create();
    }

    void updateProgress()
    {
        //calls setter at one point or may eliminate the need for the setter
    }
    public override int Award()
    {
        int pointsAwarded = 0; // resets this value for if it is called again

        if (_isComplete == true)
        {
            pointsAwarded = _progressAward + _endAward;
        }
        else
        {
            pointsAwarded += _progressAward;
        }
        return pointsAwarded;
    }

    public override void Display()
    {
    
    }

    public override void Create()
    {
        PromptTitleAndDescription();

        Console.Write("What is the amount of points associated with this goal? ");
        _progressAward = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _maxProgress = int.Parse(Console.ReadLine());

        Console.Write("How many points for the bonus? ");
        _endAward = int.Parse(Console.ReadLine());
    }
}
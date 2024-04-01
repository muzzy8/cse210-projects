class Eternal : Goal
{
    public Eternal() : base()
    {
        Create();
    }
    public override int Award()
    {
        int pointsAwarded = _progressAward;
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
    }
}
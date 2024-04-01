class Simple : Goal
{

    public Simple() : base()
    {
        Create();
    }
    public override int Award()
    {
        int pointsAwarded = _endAward;
        return pointsAwarded;
    }

    public override void Create()
    {
        PromptTitleAndDescription();
        
        Console.Write("What is the amount of points associated with this goal? ");
        _endAward = int.Parse(Console.ReadLine());
    }

    public override void Display()
    {
        
    }
}
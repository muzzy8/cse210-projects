namespace HomeworkAssignments;

class WritingAssignment : Assignment
{
    private string _title;

     public WritingAssignment(string _studentName, string _topic, string _title) : base(_studentName, _topic)
    {
        this._title = _title;
    }
    public string GetWritingInformation()
    {
        string writingInformation = $"{_title} by {_studentName}";
        return writingInformation;
    }
}
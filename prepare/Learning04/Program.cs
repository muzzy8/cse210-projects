using System;
using HomeworkAssignments;
namespace HomeworkAssignments;

class Program
{
    static void Main(string[] args)
    {
        Assignment _assignment = new Assignment("Isabelle Jimison", "Programming With Classes");

        MathAssignment _mathAssignment = new MathAssignment("Isabelle Jimison", "Algebra I", "Section 9.5", "Questions 1-10");
        
        WritingAssignment _writingAssignment = new WritingAssignment("Isabelle Jimison", "Literary Studies", "How to Judge a Book By Its Cover");

        Console.WriteLine(_assignment.GetSummary());

        Console.WriteLine(_mathAssignment.GetSummary());
        Console.WriteLine(_mathAssignment.GetHomeworkList());

        Console.WriteLine(_writingAssignment.GetSummary());
        Console.WriteLine(_writingAssignment.GetWritingInformation());
    }
}
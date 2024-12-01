using System;

namespace student;

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    List<StudentMark> StudentMarks { get; set; }
    public Subject()
    {
        StudentMarks = new List<StudentMark>();
    }
}

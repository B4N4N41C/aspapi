using System;

namespace student;

public class StudentMark
{
    public int Id { get; set; }
    public int SubjectId { get; set; }
    public required Subject Subject { get; set; }
    public int StudentId { get; set; }
    public required Student Student { get; set; }
    public int Mark { get; set; }
}

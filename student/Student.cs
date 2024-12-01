using System;

namespace student;

public class Student
{
    public int Id { get; set; }
    public string FIO { get; set; }
    public string Group { get; set; }
    public string PhoneNo { get; set; }
    public decimal Scholarship { get; set; }
    List<StudentMark> StudentMarks { get; set; }
    public Student()
    {
        StudentMarks = new List<StudentMark>();
    }
}

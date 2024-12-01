using System;

namespace student;

public class Teacher
{
    public int Id { get; set; }
    public required String Name { get; set; }
    public DateTime Birthday { get; set; }
    public float Experience { get; set; }
    public required string PhoneNo { get; set; }
    public decimal Salary { get; set; }
}

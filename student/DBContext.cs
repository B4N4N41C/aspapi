using System;

namespace student;

public class DBContext
{
    public List<Teacher> Teachers { get; set; }
    public List<Student> Students { get; set; }
    public List<Subject> Subjects { get; set; }
    public List<StudentMark> StudentMarks { get; set; }
    
    public DBContext()
    {
        Teachers = new List<Teacher>()
        {
            new Teacher()
            {
                Id = 1,
                Name = "Иванов И.И.",
                Experience = 3.4f,
                Birthday = new DateTime(1978,3,23),
                PhoneNo = "+79503451234",
                Salary = 32000
            },
            new Teacher()
            {
                Id = 2,
                Name = "Петров С.А.",
                Experience = 12.0f,
                Birthday = new DateTime(1965,6,15),
                PhoneNo = "+79190435643",
                Salary = 41500
            },
            new Teacher()
            {
                Id = 3,
                Name = "Сидоров И.Е.",
                Experience = 5.8f,
                Birthday = new DateTime(1989,12,31),
                PhoneNo = "+79158763432",
                Salary = 28300
            }
        };
        Students = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                FIO = "Максимов В.А.",
                Group = "ПИН-119",
                PhoneNo = "+79002451234",
                Scholarship = 0
            },
            new Student()
            {
                Id = 2,
                FIO = "Кузьмин Р.В.",
                Group = "ПИН-119",
                PhoneNo = "+79209435423",
                Scholarship = 5000
            },
            new Student()
            {
                Id = 3,
                FIO = "Сабжин Я.К.",
                Group = "ПИН-120",
                PhoneNo = "+79230435632",
                Scholarship = 2500
            }
        };
        Subjects = new List<Subject>()
        {
            new Subject()
            {
                Id = 1,
                Name = "Объектно-ориентированное программирование",
                TeacherId = 1,
                Teacher = Teachers.Find(t => t.Id == 1)
            },
            new Subject()
            {
                Id = 2,
                Name = "Разработка кросплатформенных приложений",
                TeacherId = 2,
                Teacher = Teachers.Find(t => t.Id == 2)
            },
            new Subject()
            {
                Id = 3,
                Name = "Системы распределенной обработки данных",
                TeacherId = 3,
                Teacher = Teachers.Find(t => t.Id == 3)
            },
            new Subject()
            {
                Id = 4,
                Name = "Системы управления базами данных",
                TeacherId = 2,
                Teacher = Teachers.Find(t => t.Id == 2)
            },
            new Subject()
            {
                Id = 5,
                Name = "Тестирование ПО",
                TeacherId = 1,
                Teacher = Teachers.Find(t => t.Id == 1)
            },
            new Subject()
            {
                Id = 6,
                Name = "Компьютерная графика",
                TeacherId = 1,
                Teacher = Teachers.Find(t => t.Id == 1)
            }
        };
        StudentMarks = new List<StudentMark>()
        {
            new StudentMark()
            {
                Id = 1,
                StudentId = 1,
                Student = Students.Find(s => s.Id == 1),
                SubjectId = 1,
                Subject = Subjects.Find(s => s.Id == 1),
                Mark = 4
            },
            new StudentMark()
            {
                Id = 2,
                StudentId = 1,
                Student = Students.Find(s => s.Id == 1),
                SubjectId = 2,
                Subject = Subjects.Find(s => s.Id == 2),
                Mark = 3
            },
            new StudentMark()
            {
                Id = 3,
                StudentId = 1,
                Student = Students.Find(s => s.Id == 1),
                SubjectId = 3,
                Subject = Subjects.Find(s => s.Id == 3),
                Mark = 5
            },
            new StudentMark()
            {
                Id = 4,
                StudentId = 1,
                Student = Students.Find(s => s.Id == 1),
                SubjectId = 5,
                Subject = Subjects.Find(s => s.Id == 5),
                Mark = 5
            },
            new StudentMark()
            {
                Id = 5,
                StudentId = 2,
                Student = Students.Find(s => s.Id == 2),
                SubjectId = 1,
                Subject = Subjects.Find(s => s.Id == 1),
                Mark = 3
            },
            new StudentMark()
            {
                Id = 6,
                StudentId = 2,
                Student = Students.Find(s => s.Id == 2),
                SubjectId = 3,
                Subject = Subjects.Find(s => s.Id == 3),
                Mark = 4
            },
            new StudentMark()
            {
                Id = 7,
                StudentId = 2,
                Student = Students.Find(s => s.Id == 2),
                SubjectId = 4,
                Subject = Subjects.Find(s => s.Id == 4),
                Mark = 3
            },
            new StudentMark()
            {
                Id = 8,
                StudentId = 2,
                Student = Students.Find(s => s.Id == 2),
                SubjectId = 6,
                Subject = Subjects.Find(s => s.Id == 6),
                Mark = 4
            },
            new StudentMark()
            {
                Id = 9,
                StudentId = 3,
                Student = Students.Find(s => s.Id == 3),
                SubjectId = 1,
                Subject = Subjects.Find(s => s.Id == 1),
                Mark = 5
            },
            new StudentMark()
            {
                Id = 10,
                StudentId = 3,
                Student = Students.Find(s => s.Id == 3),
                SubjectId = 2,
                Subject = Subjects.Find(s => s.Id == 2),
                Mark = 4
            },
            new StudentMark()
            {
                Id = 11,
                StudentId = 3,
                Student = Students.Find(s => s.Id == 3),
                SubjectId = 3,
                Subject = Subjects.Find(s => s.Id == 3),
                Mark = 5
            },
            new StudentMark()
            {
                Id = 12,
                StudentId = 3,
                Student = Students.Find(s => s.Id == 3),
                SubjectId = 4,
                Subject = Subjects.Find(s => s.Id == 4),
                Mark = 5
            },
            new StudentMark()
            {
                Id = 13,
                StudentId = 3,
                Student = Students.Find(s => s.Id == 3),
                SubjectId = 5,
                Subject = Subjects.Find(s => s.Id == 5),
                Mark = 5
            }
        };
    }
}

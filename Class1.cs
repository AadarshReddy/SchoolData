using System;
using System.Collections.Generic;

namespace SchoolData
{
    public class Teacher
    {
        public string Name { get; }
        public List<string> SubjectsTaught { get; }

        public Teacher(string name, List<string> subjectsTaught)
        {
            Name = name;
            SubjectsTaught = subjectsTaught;
        }

        // Other methods specific to a teacher
    }

    public class Student
    {
        public string Name { get; }
        public int Age { get; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Other methods specific to a student
    }

    public class Subject
    {
        public string Name { get; }
        public int HoursPerWeek { get; }

        public Subject(string name, int hoursPerWeek)
        {
            Name = name;
            HoursPerWeek = hoursPerWeek;
        }

        // Other methods specific to a subject
    }

    public class SchoolData
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private List<Subject> subjects;

        public SchoolData()
        {
            teachers = new List<Teacher>();
            students = new List<Student>();
            subjects = new List<Subject>();
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }

        // Other methods for managing school data

        public IReadOnlyList<Teacher> GetTeachers()
        {
            return teachers.AsReadOnly();
        }

        public IReadOnlyList<Student> GetStudents()
        {
            return students.AsReadOnly();
        }

        public IReadOnlyList<Subject> GetSubjects()
        {
            return subjects.AsReadOnly();
        }
    }
}

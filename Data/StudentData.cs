//Fajar Raja Nico Nainggolan
//2481023
//Framework.NET
using StudentinformationSystem.Models;

namespace StudentInformationSystem.Data
{
    // Provides sample student information.
    // Both MVC and API controllers will use this data.
    public static class StudentData
    {
        // In-memory collection of students.
        public static readonly List<Student> Students = new()
        {
            new Student
            {
                NIM = "2481023",
                Name = "Fajar Raja Nico Nainggolan",
                Major = "Teknik Informatika",
                Semester = 5,
                GPA = 3.37
            },
            new Student
            {
                NIM = "2481004",
                Name = "Chris Maruli Siagian",
                Major = "Teknik Informatika",
                Semester = 5,
                GPA = 3.66
            },
            new Student
            {
                NIM = "2481013",
                Name = "Juan Bagas Geraldo",
                Major = "Teknik Informatika",
                Semester = 5,
                GPA = 3.02
            }
        };
    }
}
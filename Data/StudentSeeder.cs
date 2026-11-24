//Fajar Raja Nico N
//2481023
//FrameWork.Net
//TI


using Microsoft.EntityFrameworkCore;
using StudentinformationSystem.Models;

namespace StudentinformationSystem.Data
{
    public static class StudentSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext db)
        {
            if (await db.Students.AnyAsync()) return;

            db.Students.AddRange(
                new Student { NIM = "2481023", Name = "Fajar Raja Nico Nainggolan", Major = "Informatics Engineering", Semester = 5, GPA = 3.85 },
                new Student { NIM = "2581001", Name = "Michael Anderson", Major = "Information Systems", Semester = 3, GPA = 3.75 },
                new Student { NIM = "2581002", Name = "Sarah Johnson", Major = "Informatics", Semester = 3, GPA = 3.88 }
            );

            await db.SaveChangesAsync();
        }
    }
}
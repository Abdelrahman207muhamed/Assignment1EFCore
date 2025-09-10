using Assignment1EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1EFCore.Contexts
{
    internal class ItiContext:DbContext
    {

        public DbSet<Student> students { get; set; }
        public DbSet<Instractor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> StudCourses { get; set; }
        public DbSet<Course_Inst> CourseInsts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = AppG03 ; Trusted_Connection = True; TrustServerCertificate = True ");
        }

    }
}

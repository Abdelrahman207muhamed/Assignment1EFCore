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
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> StudCourses { get; set; }
        public DbSet<Course_Inst> CourseInsts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");
                entity.Property(e => e.ID).IsRequired();
                entity.Property(e => e.FName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.LName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Address).HasMaxLength(250);
                entity.Property(e => e.Age).IsRequired();
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");
                entity.Property(e => e.ID).IsRequired();
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).HasMaxLength(500);
                entity.Property(e => e.Duration).IsRequired();
            });
            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("Topic");
                entity.Property(e => e.ID).IsRequired();
                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");
                entity.Property(e => e.ID).IsRequired();
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.HiringDate).HasColumnType("date");
            });
            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.ToTable("Instructor");
                entity.Property(e => e.ID).IsRequired();
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Bouns).IsRequired();
                entity.Property(e => e.Salary).IsRequired();
                entity.Property(e => e.Address).HasMaxLength(250);
                entity.Property(e => e.HourRate).IsRequired();
            });
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }

    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
    }

    public class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
    }

    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }
    }
}

    

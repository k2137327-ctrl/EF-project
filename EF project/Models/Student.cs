using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P01_StudentSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(10)]
        public string? PhoneNumber { get; set; }

        public DateTime RegisteredOn { get; set; }

        public DateTime? Birthday { get; set; }

         
        public ICollection<StudentCourse> CourseEnrollments { get; set; } = new HashSet<StudentCourse>();
        public ICollection<Homework> HomeworkSubmissions { get; set; } = new HashSet<Homework>();
    }
}
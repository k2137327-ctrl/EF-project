using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P01_StudentSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Price { get; set; }

        
        public ICollection<StudentCourse> StudentsEnrolled { get; set; } = new HashSet<StudentCourse>();
        public ICollection<Resource> Resources { get; set; } = new HashSet<Resource>();
        public ICollection<Homework> HomeworkSubmissions { get; set; } = new HashSet<Homework>();
    }
}     //في مشكله ف الmigration مش عارف اوصل لحل ليها
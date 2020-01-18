using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaceUniversity1.Models
{
    public enum Grade
    {
        A, B, C, D, E, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public virtual Course course { get; set; }
        public virtual Student Student { get; set; }

    }
}
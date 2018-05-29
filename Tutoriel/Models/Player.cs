using System;
using System.Collections.Generic;

namespace Tutoriel.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string Tag { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

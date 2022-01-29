using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class StudentCourse
    {
        public int idStudentCourse { get; set; }

        //Foreign Keys

        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}

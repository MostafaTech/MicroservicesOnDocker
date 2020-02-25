using System;
using System.Collections.Generic;

namespace MicroservicesOnDocker.Dtos
{
    public class StudentDto
    {
        public long StudentId { get; set; }
        public string StudentName { get; set; }
        public long? CourseId { get; set; }
        public string CourseName { get; set; }
        public bool HasPayed { get; set; }
    }
}

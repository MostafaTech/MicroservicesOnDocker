using System;
using System.Collections.Generic;

namespace MicroservicesOnDocker.Models
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? CourseId { get; set; }
    }
}

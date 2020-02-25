using System;
using System.Collections.Generic;

namespace MicroservicesOnDocker.Dtos
{
    public class StudentPaymentDto
    {
        public long StudentId { get; set; }
        public string StudentName { get; set; }
        public long CourseId { get; set; }
        public string CourseName { get; set; }
        public decimal PayAmount { get; set; }
    }
}

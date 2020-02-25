using System;
using System.Collections.Generic;

namespace MicroservicesOnDocker.School.Api.ViewModels
{
    public class StudentBrief
    {
        public string StudentName { get; set; }
        public string CourseName { get; set; }
        public bool HasPayed { get; set; }
    }
}

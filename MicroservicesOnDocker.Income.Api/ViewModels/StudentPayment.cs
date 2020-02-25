using System;
using System.Collections.Generic;

namespace MicroservicesOnDocker.Income.Api.ViewModels
{
    public class StudentPayment
    {
        public string StudentName { get; set; }
        public string CourseName { get; set; }
        public decimal PayAmount { get; set; }
    }
}

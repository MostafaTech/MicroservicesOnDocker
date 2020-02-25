using System;
using System.Collections.Generic;

namespace MicroservicesOnDocker.Models
{
    public class Payment
    {
        public long Id { get; set; }
        public long StudentId { get; set; }
        public long CourseId { get; set; }
        public decimal PayAmount { get; set; }
    }
}

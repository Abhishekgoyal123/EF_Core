using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string? FirstName { get; set; }
        public int? Age { get; set; }
    }
}

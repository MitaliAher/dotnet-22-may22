using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication2.Models
{
    public partial class StudentInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int? CouseId { get; set; }
        public string Gender { get; set; }
    }
}

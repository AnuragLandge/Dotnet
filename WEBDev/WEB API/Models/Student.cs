using System;
using System.Collections.Generic;

namespace WEB_API.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}

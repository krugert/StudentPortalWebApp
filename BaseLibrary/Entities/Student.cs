using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Student 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? StudentNumber { get; set; }
        public int? IDNumber { get; set; }
        // public string? Course { get; set; }
        public string? Address { get; set; }
        public string? TelephoneNumber { get; set; }

        // Relationship: many to many
        public List<Course>? Courses { get; set; }
    }
}

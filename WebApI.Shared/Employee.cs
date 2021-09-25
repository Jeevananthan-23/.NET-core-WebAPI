using System;
using System.ComponentModel.DataAnnotations;

namespace WebApI.Shared
{
    public class Employee
    {
        public int id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "FirstName must contains at least 2 charcters")]
        public string  FirstName{ get; set; }
        [Required]
        public string  LastName { get; set; }
        public string  Email { get; set; }
        public DateTime DataOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DBProjectDatabase.Models
{
    public class Teacher
    {
        [Key]
        public Guid TeacherId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        [ForeignKey("RoleId")]
        public Role? Role { get; set; }

        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }

    }
}

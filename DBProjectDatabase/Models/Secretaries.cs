using System.ComponentModel.DataAnnotations;

namespace DBProjectDatabase.Models
{
    public class Secretary
    {
        [Key]
        public Guid TeacherId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public Role? Role { get; set; }
        public Department? Department { get; set; }

    }
}

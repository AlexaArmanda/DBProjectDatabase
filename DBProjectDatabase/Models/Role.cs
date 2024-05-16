using System.ComponentModel.DataAnnotations;

namespace DBProjectDatabase.Models
{
    public class Role
    {
        [Key]
        public Guid RoleId { get; set; }
        public string Type { get; set; } = string.Empty;
    }
}
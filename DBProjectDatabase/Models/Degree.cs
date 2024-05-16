using System.ComponentModel.DataAnnotations;

namespace DBProjectDatabase.Models
{
    public class Degree
    {
        [Key]
        public Guid DegreeId { get; set; }
        public string DegreeName { get; set; } = string.Empty;
    }
}
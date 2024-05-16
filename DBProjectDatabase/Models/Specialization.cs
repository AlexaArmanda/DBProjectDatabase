using System.ComponentModel.DataAnnotations;

namespace DBProjectDatabase.Models
{
    public class Specialization
    {
        [Key]
        public Guid SpecializationId { get; set; }
        public string SpecName { get; set; } = string.Empty;
    }
}
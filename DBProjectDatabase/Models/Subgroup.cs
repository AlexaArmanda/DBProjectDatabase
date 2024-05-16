using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBProjectDatabase.Models
{
    public class Subgroup
    {
        [Key]
        public Guid SubgroupId { get; set; }

        [ForeignKey("GroupNoId")]
        public GroupNo? GroupNo { get; set; }
        public string StudentsNumber { get; set; } = string.Empty;
        public string TimetableURL { get; set; } = string.Empty;

    }
}
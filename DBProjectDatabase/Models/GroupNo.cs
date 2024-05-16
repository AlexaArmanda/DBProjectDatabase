using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBProjectDatabase.Models
{
    public class GroupNo
    {
       [Key]
        public Guid GroupNoId { get; set; }
        [ForeignKey("YearOfStudyId")]
        public YearOfStudy? YearOfStudy { get; set; }

        [ForeignKey("SpecializationId")]
        public Specialization? Specialization { get; set; }
        public int Number { get; set; }
        public int StudentsNumber { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBProjectDatabase.Models
{
    public class Subject
    {
        [Key]
        public Guid SubjectId { get; set; }

        [ForeignKey("YearOfStudyId")]
        public YearOfStudy? YearOfStudy { get; set; }

        [ForeignKey("SpecializationId")]
        public Specialization? Specialization { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public int CreditsNo { get; set; }

    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DBProjectDatabase.Models
{
    public class Grade
    {
        [Key]
        public Guid GradeId { get; set; }
        public double GradeValue { get; set; }

        [ForeignKey("StudentId")]
        public Student? Student { get; set; }

        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }
    }
}
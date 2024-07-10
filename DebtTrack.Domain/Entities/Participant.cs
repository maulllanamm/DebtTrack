using DebtTrack.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DebtTrack.Domain.Entities
{
    public class Participant : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int id { get; set; }
        public string nama { get; set; }
        public string divisi { get; set; }
        public string panggilan { get; set; }
    }
}

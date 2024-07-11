using DebtTrack.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DebtTrack.Domain.Entities
{
    public class Activity : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int id { get; set; }
        public string activity { get; set; }
        public string place { get; set; }
        public string debtor { get; set; }
        public DateTimeOffset activity_date { get; set; }
        public decimal bill{ get; set; }
        public decimal tax{ get; set; }
        public decimal total_bill{ get; set; }
    }
}

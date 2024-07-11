using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DebtTrack.Domain.Common;

namespace DebtTrack.Domain.Entities;

public class Transaction : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public override int id { get; set; }
    
    [ForeignKey("Activity")]
    public int activity_id { get; set; }
    
    [ForeignKey("Participant")]
    public int participant_id { get; set; }

    public decimal amount { get; set; }
    public decimal? total_amount_to_be_paid { get; set; }
    public string description { get; set; }
    
    public bool is_paid  { get; set; }
}


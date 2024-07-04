using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DebtTrack.Domain.Common;

namespace DebtTrack.Domain.Entities;

public class Transaction : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public override int id { get; set; }
    
    [ForeignKey("Debtor")]
    public int debtor_id { get; set; }
    
    [ForeignKey("Creditor")]
    public int creditor_id { get; set; }

    public decimal amount { get; set; }
    public string description { get; set; }
    
    public bool is_paid  { get; set; }
}


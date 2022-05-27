using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetArchitecture.Models.shared;

namespace ProjetArchitecture.Models.BankModels
{
    public class Operation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OptionId { get; set; }
        public DateTime OperationDate { get; set; }
        [ForeignKey("CompteOp")]
        public int CompteId { get; set; }
        public virtual Compte CompteOp { get; set; }
        public string NumCompte { get; set; }
        public double Montant { get; set; }
        public EnumTypeOperation TypeOperation { get; set; }

    }
}

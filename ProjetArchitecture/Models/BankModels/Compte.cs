using ProjetArchitecture.Models.shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetArchitecture.Models.BankModels
{
    public class Compte
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompteId { get; set; }
        public string NumCompte { get; set; }
        public DateTime DateCreation { get; set; }
        public EnumCompteType CompteType { get; set; }
        [ForeignKey("PropCompte")]
        public int? IdClient { get; set; }
        public virtual Client PropCompte { get; set; }
        public double Solde { get; set; }


    }
}

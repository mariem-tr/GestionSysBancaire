using ProjetArchitecture.Models.shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetArchitecture.Models.BankModels
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClient { get; set; }
        public string NumCIN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public string NumTel { get; set; }
        public string Adresse { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateJoined { get; set; }
        public EnumClientType ClientType { get; set; }
        public virtual List<Compte> ListCompte { get; set; }
        public string PrenomNom
        {
            get { return string.Concat(this.Prenom, " ", this.Nom); }
        }

    }
}

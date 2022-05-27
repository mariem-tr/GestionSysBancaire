using System.ComponentModel;

namespace ProjetArchitecture.Models.shared
{
    public enum EnumCompteType
    {
        [Description("Compte courant")]
        COURANT,
        [Description("Compte épargne")]
        EPARGNE,
        [Description("Compte business")]
        BUSINESS,
    }

    public enum EnumClientType
    {
        [Description("Individuel")]
        INDIVIDUEL,
        [Description("Entreprise")]
        ENTREPRISE,
    }
    public enum EnumRole
    {
        [Description("Client")]
        CLIENT,
        [Description("Agent")]
        AGENT,
        [Description("Admin")]
        ADMIN,
    }
    
    public enum EnumTypeOperation
    {
        [Description("Virement")]
        VIREMENT,
        [Description("Versement ")]
        VERSEMENT,
        [Description("Retrait")]
        RETRAIT,
    }
}

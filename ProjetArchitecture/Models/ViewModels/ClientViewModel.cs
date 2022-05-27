using ProjetArchitecture.Models.BankModels;
using ProjetArchitecture.Models.shared;
namespace ProjetArchitecture.Models.ViewModes
{
    public class ClientViewModel
    {
        public List<Client> ListClients { get; set; }
        public string NumCin { get; set; }
        public string Client { get; set; }
        public EnumClientType ClientType { get; set; }
        public string DateFirst { get; set; }
        public string DateSecond { get; set; }
    }

}
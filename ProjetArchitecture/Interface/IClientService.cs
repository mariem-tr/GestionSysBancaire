
using ProjetArchitecture.Models.BankModels;

namespace ProjetArchitecture.Interface
{
    public interface IClientService
    {
        IQueryable<Client> GetAllClient();
        string CreateClient(Client client);
        Client GetClientById(int id);
        string EditClient(Client client);
        string DeleteClient(int idClient);

    }
}

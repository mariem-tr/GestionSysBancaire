using ProjetArchitecture.Data;
using ProjetArchitecture.Interface;
using ProjetArchitecture.Models.BankModels;
using Microsoft.EntityFrameworkCore;
namespace ProjetArchitecture.Services
{
    public class ClientService : IClientService
    {
        private readonly ApplicationDbContext _context;
        public ClientService(ApplicationDbContext context)
        {
            _context = context;
        }

        public string CreateClient(Client client)
        {
            var rst = "Done";
            try
            {
                client.DateJoined = DateTime.Now;
                _context.Clients.Add(client);
                _context.SaveChanges();
                if (!_context.ChangeTracker.Entries().Any())
                {
                    rst = "KO";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return rst;
        }

        public string DeleteClient(int idClient)
        {
            var rst = "Done";
            try
            {
                Client existClient = _context.Clients.FirstOrDefault(x=>x.IdClient == idClient);
                _context.Clients.Remove(existClient);
                _context.SaveChanges();
                if (_context.ChangeTracker.Entries().Any())
                {
                    rst = "KO";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return rst;
        }

       
        public string EditClient(Client client)
        {
            var rst = "Done";
            try
            {
                _context.Entry(client).State = EntityState.Modified;
                _context.SaveChanges();
                if (!_context.ChangeTracker.Entries().Any())
                {
                    rst = "KO";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return rst;
        }

        public IQueryable<Client> GetAllClient()
        {
            return _context.Clients;
        }

        public Client GetClientById(int id)
        {
            return _context.Clients.FirstOrDefault(x => x.IdClient == id);
        }
        
    }
}

using ProjetArchitecture.Data;
using ProjetArchitecture.Interface;
using ProjetArchitecture.Models.BankModels;
using System.Linq.Expressions;

namespace ProjetArchitecture.Services
{
    public class OperationService : IOperationService
    {
        private readonly ApplicationDbContext _context;
        public OperationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public string CreateOperation(Operation operation, string NumCompte)
        {
            var rst = "Done";
            try
            {
                operation.NumCompte = NumCompte;
                operation.OperationDate = DateTime.Now;
                _context.Operations.Add(operation);
                _context.SaveChanges();
                if (!_context.ChangeTracker.Entries().Any())
                {
                    rst = "KO";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return rst;
        }

        public string DeleteOperation(Operation operation)
        {
            throw new NotImplementedException();
        }

        public string EditOperation(Operation operation)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Operation> GetAllOperations()
        {
            return _context.Operations;
        }

        public Operation GetOperation(Expression<Func<Operation, bool>> whereCondition)
        {
            try
            {
                return _context.Operations.FirstOrDefault(whereCondition);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

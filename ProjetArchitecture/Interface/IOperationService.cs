using ProjetArchitecture.Models.BankModels;
using System.Linq.Expressions;

namespace ProjetArchitecture.Interface
{
    public interface IOperationService
    {
        Operation GetOperation(Expression<Func<Operation, bool>> whereCondition);
        IQueryable<Operation> GetAllOperations();
        String CreateOperation(Operation operation, string NumCompte);
        string DeleteOperation(Operation operation);
        string EditOperation(Operation operation);
    }
}

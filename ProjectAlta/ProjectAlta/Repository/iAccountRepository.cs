using ProjectAlta.Entity;
using System.Collections.Generic;
namespace ProjectAlta.Repository
{
    public interface iAccountRepository
    {
        IEnumerable<Account> GetAll();
        Account GetById(int AccountID);
        void Insert(Account account);
        void Update(Account account);
        void Delete(int AccountID);
        void Save();
    }
}

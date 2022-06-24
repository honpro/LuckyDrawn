using ProjectAlta.DTO;
using ProjectAlta.Entity;
using System.Collections.Generic;
namespace ProjectAlta.Repository
{
    public interface iAccountRepository
    {
        List<AccountDTO> GetAll();
        AccountDTO GetById(int AccountID);
        bool Insert(AccountDTO account);
        bool Update(AccountDTO account);
        bool Delete(int AccountID);
        void Save();
    }
}

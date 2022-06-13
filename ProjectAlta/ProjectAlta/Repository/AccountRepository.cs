using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using System;
using System.Collections.Generic;
namespace ProjectAlta.Repository
{
    public class AccountRepository : iAccountRepository
    {
        private readonly AddContext addContext;

        public AccountRepository(AddContext addcon)
        {
            addContext =  addcon;
        }
        public void Delete(int AccountID)
        {
            Account account = addContext.Accounts.Find(AccountID);
            addContext.Accounts.Remove(account);
        }

        public IEnumerable<Account> GetAll()
        {
            return addContext.Accounts.ToList();
        }
        
        public Account GetById(int AccountID)
        {
            return addContext.Accounts.Find(AccountID);
        }

        public void Insert(Account account)
        {
            addContext.Accounts.Add(account);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(Account account)
        {
           addContext.Entry(account).State = EntityState.Modified ;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    addContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }
    }
}

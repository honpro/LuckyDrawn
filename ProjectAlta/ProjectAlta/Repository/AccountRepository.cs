using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectAlta.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IMapper admap;
        private readonly AddContext addContext;

        public AccountRepository(AddContext addcon, IMapper mapper)
        {
            addContext =  addcon;
            admap = mapper;
        }

        
        public List<AccountDTO> GetAll()
        {
            var AllAcc = addContext.Accounts.ToList();
            return admap.Map<List<AccountDTO>>(AllAcc);
        }

        

        public bool Insert(AccountDTO account)
        {
            var insertAcc = addContext.Accounts.Find(account.UserID);
            if(insertAcc == null)
            {
                addContext.Accounts.Add(admap.Map<Account>(account));
                return true;
            }
            return false;
        }

        public bool Update(AccountDTO account)
        {
            var updateAcc = addContext.Accounts.Find(account.UserID);
            if (updateAcc != null) 
            {
                addContext.Accounts.Update(admap.Map(account, updateAcc));
                return true;
            }
            return false;
        }

        public bool Delete(int AccountID)
        {
            var DeleteAcc = addContext.Accounts.Find(AccountID);
            if (DeleteAcc == null)
            {
                return false;
            }
            addContext.Remove(DeleteAcc);
            return true; 
        }

        public void Save()
        {
            addContext.SaveChanges();
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

        public AccountDTO GetById(int AccountID)
        {
            var byid = addContext.Accounts.Find(AccountID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<AccountDTO>(byid); 
        }
    }
}

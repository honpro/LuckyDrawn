using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class CustomerTypeofBussinessRepository : iCustomerTypeofBussinessRepository
    {
        private readonly AddContext addContext;

        public CustomerTypeofBussinessRepository(AddContext addcon)
        {
            addContext = addcon;
        }
        public void Delete(int CustomerTypeofBussinessID)
        {
            CustomerTypeofBussiness customerTypeofBussiness = addContext.CustomerTypeofBussinesses.Find(CustomerTypeofBussinessID);
            addContext.CustomerTypeofBussinesses.Remove(customerTypeofBussiness);
        }

        public IEnumerable<CustomerTypeofBussiness> GetAll()
        {
            return addContext.CustomerTypeofBussinesses.ToList();
        }

        public CustomerTypeofBussiness GetById(int CustomerTypeofBussinessID)
        {
            return addContext.CustomerTypeofBussinesses.Find(CustomerTypeofBussinessID);
        }

        public void Insert(CustomerTypeofBussiness CustomerTypeofBussiness)
        {
             addContext.CustomerTypeofBussinesses.Add(CustomerTypeofBussiness);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(CustomerTypeofBussiness CustomerTypeofBussiness)
        {
           addContext.Entry(CustomerTypeofBussiness).State = EntityState.Modified;
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

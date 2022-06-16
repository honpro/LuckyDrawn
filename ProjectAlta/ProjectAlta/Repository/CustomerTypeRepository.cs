using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class CustomerTypeRepository : iCustomerTypeRepository
    {
        private readonly AddContext addContext;

        public CustomerTypeRepository(AddContext addcon)
        {
            addContext = addcon;
        }
        public void Delete(int CustomerTypeID)
        {
            CustomerType customerType = addContext.CustomerTypes.Find(CustomerTypeID);
            addContext.CustomerTypes.Remove(customerType);
        }

        public IEnumerable<CustomerType> GetAll()
        {
            return addContext.CustomerTypes.ToList();
        }

        public CustomerType GetById(int CustomerTypeID)
        {
            return addContext.CustomerTypes.Find(CustomerTypeID);
        }

        public void Insert(CustomerType CustomerType)
        {
            addContext.CustomerTypes.Add(CustomerType);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(CustomerType CustomerType)
        {
            addContext.Entry(CustomerType).State = EntityState.Modified;
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

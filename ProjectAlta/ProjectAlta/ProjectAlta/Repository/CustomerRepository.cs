using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class CustomerRepository : iCustomerRepository
    {
        private readonly AddContext addContext;

        public CustomerRepository(AddContext addcon)
        {
            addContext = addcon;
        }
        public void Delete(int CustomerID)
        {
           Customer customer = addContext.Customers.Find(CustomerID);
            addContext.Customers.Remove(customer);
        }

        public IEnumerable<Customer> GetAll()
        {
           return addContext.Customers.ToList();
        }

        public Customer GetById(int CustomerID)
        {
          return  addContext.Customers.Find(CustomerID);
        }

        public void Insert(Customer Customer)
        {
            addContext.Customers.Add(Customer);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(Customer Customer)
        {
            addContext.Entry(Customer).State = EntityState.Modified;
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

using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class GiftRepository : iGiftRepository
    {
        private readonly AddContext addContext;

        public GiftRepository(AddContext addcon)
        {
            addContext = addcon;
        }
        public void Delete(int GiftID)
        {
            Gift gift = addContext.Gifts.Find(GiftID);
            addContext.Gifts.Remove(gift);
        }

        public IEnumerable<Gift> GetAll()
        {
           return addContext.Gifts.ToList();
        }

        public Gift GetById(int GiftID)
        {
            return addContext.Gifts.Find(GiftID);
        }

        public void Insert(Gift Gift)
        {
            addContext.Gifts.Add(Gift);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(Gift Gift)
        {
            addContext.Entry(Gift).State = EntityState.Modified;
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

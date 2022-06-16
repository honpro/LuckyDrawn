using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class RulesForGiftRepository : iRulesForGiftRepository
    {
        private readonly AddContext addContext;

        public RulesForGiftRepository(AddContext addcon)
        {
            addContext = addcon;
        }
        public void Delete(int RulesForGiftID)
        {
           RulesForGift rulesForGift = addContext.RulesForGifts.Find(RulesForGiftID);
            addContext.RulesForGifts.Remove(rulesForGift);
        }

        public IEnumerable<RulesForGift> GetAll()
        {
            return addContext.RulesForGifts.ToList();
        }

        public RulesForGift GetById(int RulesForGiftID)
        {
            return addContext.RulesForGifts.Find(RulesForGiftID);
        }

        public void Insert(RulesForGift RulesForGift)
        {
            addContext.RulesForGifts.Add(RulesForGift);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(RulesForGift RulesForGift)
        {
            addContext.Entry(RulesForGift).State = EntityState.Modified;
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

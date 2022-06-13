using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class BarcodesUsageHistoryRepository : iBarcodesUsageHistoryRepository
    {
        private readonly AddContext addContext;

        public BarcodesUsageHistoryRepository(AddContext addcon)
        {
            addContext = addcon;
        }

        public void Delete(int BarcodesUsageHistoryID)
        {
            BarcodesUsageHistory barcodesUsageHistory = addContext.BarcodesUsageHistories.Find(BarcodesUsageHistoryID);
            addContext.BarcodesUsageHistories.Remove(barcodesUsageHistory);
        }

        public IEnumerable<BarcodesUsageHistory> GetAll()
        {
           return addContext.BarcodesUsageHistories.ToList();
        }

        public BarcodesUsageHistory GetById(int BarcodesUsageHistoryID)
        {
           return addContext.BarcodesUsageHistories.Find(BarcodesUsageHistoryID);
        }

        public void Insert(BarcodesUsageHistory barcodesUsageHistory)
        {
           addContext.BarcodesUsageHistories.Add(barcodesUsageHistory);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(BarcodesUsageHistory barcodesUsageHistory)
        {
            addContext.Entry(barcodesUsageHistory).State = EntityState.Modified;
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

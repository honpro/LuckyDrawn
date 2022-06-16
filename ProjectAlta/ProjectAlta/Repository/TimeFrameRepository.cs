using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class TimeFrameRepository : iTimeFrameRepository
    {
        private readonly AddContext addContext;

        public TimeFrameRepository(AddContext addcon)
        {
            addContext = addcon;
        }
        public void Delete(int TimeFrameID)
        {
            TimeFrame timeFrame = addContext.TimeFrames.Find(TimeFrameID);
            addContext.TimeFrames.Remove(timeFrame);
        }

        public IEnumerable<TimeFrame> GetAll()
        {
            return addContext.TimeFrames.ToList();
        }

        public TimeFrame GetById(int TimeFrameID)
        {
            return addContext.TimeFrames.Find(TimeFrameID);
        }

        public void Insert(TimeFrame TimeFrame)
        {
           addContext.TimeFrames.Add(TimeFrame);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(TimeFrame TimeFrame)
        {
            addContext.Entry(TimeFrame).State = EntityState.Modified;
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

using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class GiftsOfCampignRepository : iGiftsOfCampignRepository
    {
        private readonly AddContext addContext;

        public GiftsOfCampignRepository(AddContext addcon)
        {
            addContext = addcon;
        }
        public void Delete(int GiftsOfCampignID)
        {
            GiftsOfCampign giftsOfCampign = addContext.GiftsOfCampigns.Find(GiftsOfCampignID);
            addContext.GiftsOfCampigns.Remove(giftsOfCampign);
        }

        public IEnumerable<GiftsOfCampign> GetAll()
        {
            return addContext.GiftsOfCampigns.ToList();
        }

        public GiftsOfCampign GetById(int GiftsOfCampignID)
        {
            return addContext.GiftsOfCampigns.Find(GiftsOfCampignID);
        }

        public void Insert(GiftsOfCampign GiftsOfCampign)
        {
            addContext.GiftsOfCampigns.Add(GiftsOfCampign);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(GiftsOfCampign GiftsOfCampign)
        {
            addContext.Entry(GiftsOfCampign).State = EntityState.Modified;
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

using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class CharsetTypeRepository : iCharsetTypeRepository
    {
        private readonly AddContext addContext;

        public CharsetTypeRepository (AddContext addcon)
        {
            addContext = addcon;
        }

        public void Delete(int charsetTypeID)
        {
            CharsetType charsetType = addContext.CharsetTypes.Find(charsetTypeID);
            addContext.CharsetTypes.Remove(charsetType);
        }

        public IEnumerable<CharsetType> GetAll()
        {
            return addContext.CharsetTypes.ToList();
        }

        public CharsetType GetById(int charsetTypeID)
        {
            return addContext.CharsetTypes.Find(charsetTypeID);
        }

        public void Insert(CharsetType charsetType)
        {
            addContext.CharsetTypes.Add(charsetType);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(CharsetType charsetType)
        {
            addContext.Entry(charsetType).State = EntityState.Modified;
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

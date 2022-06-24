using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class ProgramSizeRepository : iProgramSizeRepository
    {
        private readonly AddContext addContext;

        public ProgramSizeRepository(AddContext addcon)
        {
            addContext = addcon;
        }
        public void Delete(int ProgramSizeID)
        {
           ProgramSize programSize = addContext.ProgramSizes.Find(ProgramSizeID);
            addContext.ProgramSizes.Remove(programSize);
        }

        public IEnumerable<ProgramSize> GetAll()
        {
            return addContext.ProgramSizes.ToList();
        }

        public ProgramSize GetById(int ProgramSizeID)
        {
            return addContext.ProgramSizes.Find(ProgramSizeID);
        }

        public void Insert(ProgramSize ProgramSize)
        {
            addContext.ProgramSizes.Add(ProgramSize);
        }

        public void Save()
        {
           addContext.SaveChanges();
        }

        public void Update(ProgramSize ProgramSize)
        {
            addContext.Entry(ProgramSize).State = EntityState.Modified;
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

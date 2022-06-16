using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class CodeDetailRepository : iCodeDetailRepository
    {
        private readonly AddContext addContext;

        public CodeDetailRepository(AddContext addcon)
        {
            addContext = addcon;
        }
        public void Delete(int CodeDetailID)
        {
           CodeDetail codeDetail = addContext.CodeDetails.Find(CodeDetailID);
            addContext.CodeDetails.Remove(codeDetail);
        }

        public IEnumerable<CodeDetail> GetAll()
        {
            return addContext.CodeDetails.ToList();
        }

        public CodeDetail GetById(int CodeDetailID)
        {
            return addContext.CodeDetails.Find(CodeDetailID);
        }

        public void Insert(CodeDetail codeDetail)
        {
            addContext.CodeDetails.Add(codeDetail);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(CodeDetail codeDetail)
        {
           addContext.Entry(codeDetail).State = EntityState.Modified;
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

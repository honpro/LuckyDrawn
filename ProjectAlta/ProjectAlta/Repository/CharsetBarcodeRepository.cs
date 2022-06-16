using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class CharsetBarcodeRepository : iCharsetBarcodeRepository
    {
        private readonly AddContext addContext;

        public CharsetBarcodeRepository (AddContext addcon)
        {
            addContext = addcon;
        }

        public void Delete(int CharsetBarcodeID)
        {
            CharsetBarcode charsetBarcode = addContext.CharsetBarcodes.Find(CharsetBarcodeID);
            addContext.CharsetBarcodes.Remove(charsetBarcode);
        }

        public IEnumerable<CharsetBarcode> GetAll()
        {
            return addContext.CharsetBarcodes.ToList();
        }

        public CharsetBarcode GetById(int CharsetBarcodeID)
        {
            return addContext.CharsetBarcodes.Find(CharsetBarcodeID);
        }

        public void Insert(CharsetBarcode charsetBarcode)
        {
            addContext.CharsetBarcodes.Add(charsetBarcode);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(CharsetBarcode charsetBarcode)
        {
            addContext.Entry(charsetBarcode).State = EntityState.Modified;
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

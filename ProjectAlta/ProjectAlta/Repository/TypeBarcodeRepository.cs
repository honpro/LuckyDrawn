using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class TypeBarcodeRepository : iTypeBarcodeRepository
    {
        private readonly AddContext addContext;

        public TypeBarcodeRepository(AddContext addcon)
        {
            addContext = addcon;
        }
        public void Delete(int TypeBarcodeID)
        {
            TypeBarcode typeBarcode = addContext.TypeBarcodes.Find(TypeBarcodeID);
            addContext.TypeBarcodes.Remove(typeBarcode);
        }

        public IEnumerable<TypeBarcode> GetAll()
        {
            return addContext.TypeBarcodes.ToList();
        }

        public TypeBarcode GetById(int TypeBarcodeID)
        {
            return addContext.TypeBarcodes.Find(TypeBarcodeID);
        }

        public void Insert(TypeBarcode TypeBarcode)
        {
            addContext.TypeBarcodes.Add(TypeBarcode);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(TypeBarcode TypeBarcode)
        {
            addContext.Entry(TypeBarcode).State = EntityState.Modified;
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

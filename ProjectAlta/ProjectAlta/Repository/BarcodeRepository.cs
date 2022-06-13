using ProjectAlta.Context;
using ProjectAlta.Entity;
using System;
using System.Collections.Generic;
namespace ProjectAlta.Repository
{
    public class BarcodesRepository : iBarcodeRepository 
    {
        private readonly AddContext  addContext;

        public BarcodesRepository (AddContext addcon)
        {
            addContext = addcon;
        }
        public void Delete(int BarcodeID)
        {
            Barcode barcode = addContext.Barcodes.Find(BarcodeID);
            addContext.Barcodes.Remove(barcode);
        }

        public IEnumerable<Barcode> GetAll()
        {
            return addContext.Barcodes.ToList();
        }

        public Barcode GetById(int BarcodeID)
        {
            return addContext.Barcodes.Find(BarcodeID);
        }

        public void Insert(Barcode barcode)
        {
           addContext.Barcodes.Add(barcode);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(Barcode barcode)
        {
            addContext.Entry(barcode).State = Microsoft.EntityFrameworkCore.EntityState.Modified ;
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

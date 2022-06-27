using AutoMapper;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;
using System;
using System.Collections.Generic;
namespace ProjectAlta.Repository
{
    public class BarcodesRepository : IBarcodeRepository
    {
        private readonly AddContext  addContext;
        private readonly IMapper admap;

        public BarcodesRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }


        public List<BarcodeDTO> GetAll()
        {
            var AllBar = addContext.Barcodes.ToList();
            return admap.Map<List<BarcodeDTO>>(AllBar);
        }

        public BarcodeDTO GetById(int BarcodeID)
        {
           var byid = addContext.Barcodes.Find(BarcodeID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<BarcodeDTO>(byid);
        }

        public bool Insert(BarcodeDTO barcode)
        {
            var insertBar = addContext.Barcodes.Find(barcode.BarcodeID);
            if (insertBar== null)
            {
                addContext.Barcodes.Add(admap.Map<Barcode>(barcode));
                return true;
            }
            return false;
        }

        public bool Update(BarcodeDTO barcode)
        {
            var updateBar = addContext.Barcodes.Find(barcode.BarcodeID);
            if (updateBar != null)
            {
                addContext.Barcodes.Update(admap.Map(barcode, updateBar));
                return true;
            }
            return false;
        }

        public bool Delete(int BarcodeID)
        {
            var DeleteBar = addContext.Barcodes.Find(BarcodeID);
            if (DeleteBar== null)
            {
                return false;
            }
            addContext.Remove(DeleteBar);
            return true;
        }

        public void Save()
        {
            addContext.SaveChanges();
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

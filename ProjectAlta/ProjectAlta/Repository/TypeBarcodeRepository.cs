using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class TypeBarcodeRepository : iTypeBarcodeRepository
    {
        private readonly AddContext addContext;
        private readonly IMapper admap;

        public TypeBarcodeRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }
        
        

        public List<TypeBarcodeDTO> GetAll()
        {
            var allTyBa = addContext.TypeBarcodes.ToList();
            return admap.Map<List<TypeBarcodeDTO>>(allTyBa);
        }

        public TypeBarcodeDTO GetById(int TypeBarcodeID)
        {
            var byid = addContext.TypeBarcodes.Find(TypeBarcodeID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<TypeBarcodeDTO>(byid);
        }

        public bool Insert(TypeBarcodeDTO TypeBarcodeDTO)
        {
            var insertTyBa = addContext.TypeBarcodes.Find(TypeBarcodeDTO.TypeBarcodeID);
            if (insertTyBa == null)
            {
                addContext.TypeBarcodes.Add(admap.Map<TypeBarcode>(TypeBarcodeDTO));
                return true;
            }
            return false;
        }

        public bool Update(TypeBarcodeDTO TypeBarcodeDTO)
        {
            var updateTyBa = addContext.TypeBarcodes.Find(TypeBarcodeDTO.TypeBarcodeID);
            if (updateTyBa != null)
            {
                addContext.TypeBarcodes.Update(admap.Map(TypeBarcodeDTO, updateTyBa));
                return true;
            }
            return false;
        }

        public bool Delete(int TypeBarcodeID)
        {
            var DeleteTyBa = addContext.TypeBarcodes.Find(TypeBarcodeID);
            if (DeleteTyBa == null)
            {
                return false;
            }
            addContext.Remove(DeleteTyBa);
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

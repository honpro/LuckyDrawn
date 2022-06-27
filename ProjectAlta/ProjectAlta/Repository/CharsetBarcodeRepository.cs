using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class CharsetBarcodeRepository : ICharsetBarcodeRepository
    {
        private readonly AddContext addContext;
        private readonly IMapper admap;

        public CharsetBarcodeRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }

        public List<CharsetBarcodeDTO> GetAll()
        {
            var allCha = addContext.CharsetBarcodes.ToList();
            return admap.Map<List<CharsetBarcodeDTO>>(allCha);
        }

        public CharsetBarcodeDTO GetById(int CharsetBarcodeID)
        {
            var byid = addContext.CharsetBarcodes.Find(CharsetBarcodeID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<CharsetBarcodeDTO>(byid);
        }

        public bool Insert(CharsetBarcodeDTO charsetBarcodeDTO)
        {
            var insertCha = addContext.CharsetBarcodes.Find(charsetBarcodeDTO.CharsetBarcodeID);
            if (insertCha == null)
            {
                addContext.CharsetBarcodes.Add(admap.Map<CharsetBarcode>(charsetBarcodeDTO));
                return true;
            }
            return false;
        }

        public bool Update(CharsetBarcodeDTO charsetBarcodeDTO)
        {
            var updateCha = addContext.CharsetBarcodes.Find(charsetBarcodeDTO.CharsetBarcodeID);
            if (updateCha != null)
            {
                addContext.CharsetBarcodes.Update(admap.Map(charsetBarcodeDTO, updateCha));
                return true;
            }
            return false;
        }

        public bool Delete(int CharsetBarcodeID)
        {
            var DeleteCha = addContext.CharsetBarcodes.Find(CharsetBarcodeID);
            if (DeleteCha == null)
            {
                return false;
            }
            addContext.Remove(DeleteCha);
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

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class CharsetTypeRepository : iCharsetTypeRepository
    {
        private readonly AddContext addContext;
        private readonly IMapper admap;

        public CharsetTypeRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }

        public bool Delete(int charsetTypeID)
        {
            var DeleteCha = addContext.CharsetTypes.Find(charsetTypeID);
            if (DeleteCha == null)
            {
                return false;
            }
            addContext.Remove(DeleteCha);
            return true; 
        }

        public List<CharsetTypeDTO> GetAll()
        {
            var allCha = addContext.CharsetBarcodes.ToList();
            return admap.Map<List<CharsetTypeDTO>>(allCha);
        }

        public CharsetTypeDTO GetById(int charsetTypeID)
        {
            var byid = addContext.CharsetTypes.Find(charsetTypeID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<CharsetTypeDTO>(byid);
        }

        public bool Insert(CharsetTypeDTO charsetTypeDTO)
        {
            var insertCha = addContext.CharsetTypes.Find(charsetTypeDTO.CharsetTypeID);
            if (insertCha == null)
            {
                addContext.CharsetTypes.Add(admap.Map<CharsetType>(charsetTypeDTO));
                return true;
            }
            return false;
        }

        public void Save()
        {
           addContext.SaveChanges();
        }

        public bool Update(CharsetTypeDTO charsetTypeDTO)
        {
            var updateCha = addContext.CharsetTypes.Find(charsetTypeDTO.CharsetTypeID);
            if (updateCha != null)
            {
                addContext.CharsetTypes.Update(admap.Map(charsetTypeDTO, updateCha));
                return true;
            }
            return false;
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

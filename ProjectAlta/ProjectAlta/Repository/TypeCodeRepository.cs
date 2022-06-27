using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;

namespace ProjectAlta.Repository
{
    public class TypeCodeRepository : ITypeCodeRepository
    {
        private readonly AddContext addContext;
        private readonly IMapper admap;

        public TypeCodeRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }

        public bool Delete(int TypeCodeID)
        {
            var DeleteTyBa = addContext.TypeCodes.Find(TypeCodeID);
            if (DeleteTyBa == null)
            {
                return false;
            }
            addContext.Remove(DeleteTyBa);
            return true;
        }

        public List<TypeCodeDTO> GetAll()
        {
            var allTyBa = addContext.TypeCodes.ToList();
            return admap.Map<List<TypeCodeDTO>>(allTyBa);
        }

        public TypeCodeDTO GetById(int TypeCodeID)
        {
            var byid = addContext.TypeCodes.Find(TypeCodeID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<TypeCodeDTO>(byid);
        }

        public bool Insert(TypeCodeDTO TypeCodeDTO)
        {
            var insertTyBa = addContext.TypeCodes.Find(TypeCodeDTO.TypeCodeID);
            if (insertTyBa == null)
            {
                addContext.TypeCodes.Add(admap.Map<Entity.TypeCode>(TypeCodeDTO));
                return true;
            }
            return false;
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public bool Update(TypeCodeDTO TypeCodeDTO)
        {
            var updateTyBa = addContext.TypeCodes.Find(TypeCodeDTO.TypeCodeID);
            if (updateTyBa != null)
            {
                addContext.TypeCodes.Update(admap.Map(TypeCodeDTO, updateTyBa));
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

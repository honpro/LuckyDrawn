using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class ProgramSizeRepository : IProgramSizeRepository
    {
        private readonly AddContext addContext;
        private readonly IMapper admap;

        public ProgramSizeRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }

        public bool Delete(int ProgramSizeID)
        {
            var DeletePro = addContext.ProgramSizes.Find(ProgramSizeID);
            if (DeletePro == null)
            {
                return false;
            }
            addContext.Remove(DeletePro);
            return true;
        }

        public List<ProgramSizeDTO> GetAll()
        {
            var allPro = addContext.ProgramSizes.ToList();
            return admap.Map<List<ProgramSizeDTO>>(allPro);
        }

        public ProgramSizeDTO GetById(int ProgramSizeID)
        {
            var byid = addContext.ProgramSizes.Find(ProgramSizeID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<ProgramSizeDTO>(byid);
        }

        public bool Insert(ProgramSizeDTO ProgramSizeDTO)
        {
            var insertPro = addContext.ProgramSizes.Find(ProgramSizeDTO.ProgramSizeID);
            if (insertPro == null)
            {
                addContext.ProgramSizes.Add(admap.Map<ProgramSize>(ProgramSizeDTO));
                return true;
            }
            return false;
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public bool Update(ProgramSizeDTO ProgramSizeDTO)
        {
            var updatePro = addContext.ProgramSizes.Find(ProgramSizeDTO.ProgramSizeID);
            if (updatePro != null)
            {
                addContext.ProgramSizes.Update(admap.Map(ProgramSizeDTO, updatePro));
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

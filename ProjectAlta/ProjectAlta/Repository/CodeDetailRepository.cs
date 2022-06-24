using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class CodeDetailRepository : iCodeDetailRepository
    {
        private readonly AddContext addContext;
        private readonly IMapper admap;

        public CodeDetailRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }

        

        public List<CodeDetailDTO> GetAll()
        {
            var allCode = addContext.CodeDetails.ToList();
            return admap.Map<List<CodeDetailDTO>>(allCode);
        }

        public CodeDetailDTO GetById(int CodeDetailID)
        {
            var byid = addContext.CodeDetails.Find(CodeDetailID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<CodeDetailDTO>(byid);
        }

        public bool Insert(CodeDetailDTO codeDetailDTO)
        {
            var insertCode = addContext.CodeDetails.Find(codeDetailDTO.CodeDetailID);
            if (insertCode == null)
            {
                addContext.CodeDetails.Add(admap.Map<CodeDetail>(codeDetailDTO));
                return true;
            }
            return false;
        }

        public bool Update(CodeDetailDTO codeDetailDTO)
        {
            var updateCode = addContext.CodeDetails.Find(codeDetailDTO.CodeDetailID);
            if (updateCode != null)
            {
                addContext.CodeDetails.Update(admap.Map(codeDetailDTO, updateCode));
                return true;
            }
            return false;
        }

        public bool Delete(int CodeDetailID)
        {
            var DeleteCode = addContext.CodeDetails.Find(CodeDetailID);
            if (DeleteCode == null)
            {
                return false;
            }
            addContext.Remove(DeleteCode);
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

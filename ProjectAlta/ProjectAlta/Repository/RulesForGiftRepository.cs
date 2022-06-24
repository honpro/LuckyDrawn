using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class RulesForGiftRepository : iRulesForGiftRepository
    {
        private readonly AddContext addContext;
        private readonly IMapper admap;

        public RulesForGiftRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }
        
        
        public List<RulesForGiftDTO> GetAll()
        {
            var allRu = addContext.RulesForGifts.ToList();
            return admap.Map<List<RulesForGiftDTO>>(allRu);
        }

        public RulesForGiftDTO GetById(int RulesForGiftID)
        {
            var byid = addContext.RulesForGifts.Find(RulesForGiftID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<RulesForGiftDTO>(byid);
        }

        public bool Insert(RulesForGiftDTO RulesForGiftDTO)
        {
            var insertRu = addContext.RulesForGifts.Find(RulesForGiftDTO.RulesForGiftsID);
            if (insertRu == null)
            {
                addContext.RulesForGifts.Add(admap.Map<RulesForGift>(RulesForGiftDTO));
                return true;
            }
            return false;
        }

        public bool Update(RulesForGiftDTO RulesForGiftDTO)
        {
            var updateRu = addContext.RulesForGifts.Find(RulesForGiftDTO.RulesForGiftsID);
            if (updateRu != null)
            {
                addContext.RulesForGifts.Update(admap.Map(RulesForGiftDTO, updateRu));
                return true;
            }
            return false;
        }

        public bool Delete(int RulesForGiftID)
        {
            var DeleteRu = addContext.RulesForGifts.Find(RulesForGiftID);
            if (DeleteRu == null)
            {
                return false;
            }
            addContext.Remove(DeleteRu);
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

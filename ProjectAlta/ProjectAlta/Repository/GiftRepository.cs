using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class GiftRepository : IGiftRepository
    {
        private readonly AddContext addContext;
        private readonly IMapper admap;

        public GiftRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }

        public bool Delete(int GiftID)
        {
            var DeleteGif = addContext.Gifts.Find(GiftID);
            if (DeleteGif == null)
            {
                return false;
            }
            addContext.Remove(DeleteGif);
            return true;
        }

        public List<GiftDTO> GetAll()
        {
            var allGif = addContext.Gifts.ToList();
            return admap.Map<List<GiftDTO>>(allGif);
        }

        public GiftDTO GetById(int GiftID)
        {
            var byid = addContext.Gifts.Find(GiftID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<GiftDTO>(byid);
        }

        public bool Insert(GiftDTO GiftDTO)
        {
            var insertGif = addContext.Gifts.Find(GiftDTO.GiftsID);
            if (insertGif == null)
            {
                addContext.Gifts.Add(admap.Map<Gift>(GiftDTO));
                return true;
            }
            return false;
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public bool Update(GiftDTO GiftDTO)
        {
            var updateGif = addContext.Gifts.Find(GiftDTO.GiftsID);
            if (updateGif != null)
            {
                addContext.Gifts.Update(admap.Map(GiftDTO, updateGif));
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

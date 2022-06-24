using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class GiftsOfCampignRepository : iGiftsOfCampignRepository
    {
        private readonly AddContext addContext;
        private readonly IMapper admap;

        public GiftsOfCampignRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }

        public bool Delete(int GiftsOfCampignID)
        {
            var DeleteGif = addContext.GiftsOfCampigns.Find(GiftsOfCampignID);
            if (DeleteGif == null)
            {
                return false;
            }
            addContext.Remove(DeleteGif);
            return true;
        }

        public List<GiftsOfCampignDTO> GetAll()
        {
            var allGif = addContext.GiftsOfCampigns.ToList();
            return admap.Map<List<GiftsOfCampignDTO>>(allGif);
        }

        public GiftsOfCampignDTO GetById(int GiftsOfCampignID)
        {
            var byid = addContext.GiftsOfCampigns.Find(GiftsOfCampignID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<GiftsOfCampignDTO>(byid);
        }

        public bool Insert(GiftsOfCampignDTO GiftsOfCampignDTO)
        {
            var insertGif = addContext.GiftsOfCampigns.Find(GiftsOfCampignDTO.GiftsOfCampignID);
            if (insertGif == null)
            {
                addContext.GiftsOfCampigns.Add(admap.Map<GiftsOfCampign>(GiftsOfCampignDTO));
                return true;
            }
            return false;
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public bool Update(GiftsOfCampignDTO GiftsOfCampignDTO)
        {
            var updateGif = addContext.GiftsOfCampigns.Find(GiftsOfCampignDTO.GiftsOfCampignID);
            if (updateGif != null)
            {
                addContext.GiftsOfCampigns.Update(admap.Map(GiftsOfCampignDTO, updateGif));
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

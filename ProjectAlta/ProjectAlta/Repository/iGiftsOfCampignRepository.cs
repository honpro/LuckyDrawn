using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface iGiftsOfCampignRepository
    {
        IEnumerable<GiftsOfCampign> GetAll();
        GiftsOfCampign GetById(int GiftsOfCampignID);
        void Insert(GiftsOfCampign GiftsOfCampign);
        void Update(GiftsOfCampign GiftsOfCampign);
        void Delete(int GiftsOfCampignID);
        void Save();
    }
}

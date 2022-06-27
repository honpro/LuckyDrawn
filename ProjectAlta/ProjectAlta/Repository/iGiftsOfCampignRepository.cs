using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface IGiftsOfCampignRepository
    {
        List<GiftsOfCampignDTO> GetAll();
        GiftsOfCampignDTO GetById(int GiftsOfCampignID);
        bool Insert(GiftsOfCampignDTO GiftsOfCampignDTO);
        bool Update(GiftsOfCampignDTO GiftsOfCampignDTO);
        bool Delete(int GiftsOfCampignID);
        void Save();
    }
}

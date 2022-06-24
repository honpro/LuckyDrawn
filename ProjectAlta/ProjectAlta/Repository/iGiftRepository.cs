using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface iGiftRepository
    {
        List<GiftDTO> GetAll();
        GiftDTO GetById(int GiftID);
        bool Insert(GiftDTO GiftDTO);
        bool Update(GiftDTO GiftDTO);
        bool Delete(int GiftID);
        void Save();
    }
}

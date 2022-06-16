using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface iGiftRepository
    {
        IEnumerable<Gift> GetAll();
        Gift GetById(int GiftID);
        void Insert(Gift Gift);
        void Update(Gift Gift);
        void Delete(int GiftID);
        void Save();
    }
}

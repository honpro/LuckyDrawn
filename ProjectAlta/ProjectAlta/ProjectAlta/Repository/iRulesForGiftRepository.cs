using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface iRulesForGiftRepository
    {
        IEnumerable<RulesForGift> GetAll();
        RulesForGift GetById(int RulesForGiftID);
        void Insert(RulesForGift RulesForGift);
        void Update(RulesForGift RulesForGift);
        void Delete(int RulesForGiftID);
        void Save();
    }
}

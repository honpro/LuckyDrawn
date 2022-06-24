using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface iRulesForGiftRepository
    {
       List<RulesForGiftDTO> GetAll();
        RulesForGiftDTO GetById(int RulesForGiftID);
        bool Insert(RulesForGiftDTO RulesForGiftDTO);
        bool Update(RulesForGiftDTO RulesForGiftDTO);
        bool Delete(int RulesForGiftID);
        void Save();
    }
}

using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface ISettingRepository
    {
        List<SettingDTO> GetAll();
        SettingDTO GetById(int SettingID);
        bool Insert(SettingDTO SettingDTO);
        bool Update(SettingDTO SettingDTO);
        bool Delete(int SettingID);
        void Save();
    }
}

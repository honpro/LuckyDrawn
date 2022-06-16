using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface iSettingRepository
    {
        IEnumerable<Setting> GetAll();
        Setting GetById(int SettingID);
        void Insert(Setting Setting);
        void Update(Setting Setting);
        void Delete(int SettingID);
        void Save();
    }
}

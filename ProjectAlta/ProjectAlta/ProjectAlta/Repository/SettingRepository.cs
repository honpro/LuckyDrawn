using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class SettingRepository : iSettingRepository
    {
        private readonly AddContext addContext;

        public SettingRepository(AddContext addcon)
        {
            addContext = addcon;
        }
        public void Delete(int SettingID)
        {
            Setting setting = addContext.Settings.Find(SettingID);
            addContext.Settings.Remove(setting);
        }

        public IEnumerable<Setting> GetAll()
        {
            return addContext.Settings.ToList() ;
        }

        public Setting GetById(int SettingID)
        {
            return addContext.Settings.Find(SettingID);
        }

        public void Insert(Setting Setting)
        {
            addContext.Settings.Add(Setting);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(Setting Setting)
        {
            addContext.Entry(Setting).State = EntityState.Modified;
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

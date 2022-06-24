using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class SettingRepository : iSettingRepository
    {
        private readonly AddContext addContext;
        private readonly IMapper admap;

        public SettingRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }

        

        public List<SettingDTO> GetAll()
        {
            var allSet = addContext.Settings.ToList();
            return admap.Map<List<SettingDTO>>(allSet);
        }

        public SettingDTO GetById(int SettingID)
        {
            var byid = addContext.Settings.Find(SettingID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<SettingDTO>(byid);
        }

        public bool Insert(SettingDTO SettingDTO)
        {
            var insertSet = addContext.Settings.Find(SettingDTO.SettingID);
            if (insertSet == null)
            {
                addContext.Settings.Add(admap.Map<Setting>(SettingDTO));
                return true;
            }
            return false;
        }

        public bool Update(SettingDTO SettingDTO)
        {
            var updateSet = addContext.Settings.Find(SettingDTO.SettingID);
            if (updateSet != null)
            {
                addContext.Settings.Update(admap.Map(SettingDTO, updateSet));
                return true;
            }
            return false;
        }

        public bool Delete(int SettingID)
        {
            var DeleteSet = addContext.Settings.Find(SettingID);
            if (DeleteSet == null)
            {
                return false;
            }
            addContext.Remove(DeleteSet);
            return true;
        }

        public void Save()
        {
            addContext.SaveChanges();
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

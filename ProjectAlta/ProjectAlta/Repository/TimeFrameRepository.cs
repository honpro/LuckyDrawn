using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class TimeFrameRepository : iTimeFrameRepository
    {
        private readonly AddContext addContext;
        private readonly IMapper admap;

        public TimeFrameRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }
       
        

        public List<TimeFrameDTO> GetAll()
        {
            var allTim = addContext.TimeFrames.ToList();
            return admap.Map<List<TimeFrameDTO>>(allTim);
        }

        public TimeFrameDTO GetById(int TimeFrameID)
        {
            var byid = addContext.TimeFrames.Find(TimeFrameID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<TimeFrameDTO>(byid);
        }

        public bool Insert(TimeFrameDTO TimeFrameDTO)
        {
            var insertTim = addContext.TimeFrames.Find(TimeFrameDTO.TimeFrameID);
            if (insertTim == null)
            {
                addContext.TimeFrames.Add(admap.Map<TimeFrame>(TimeFrameDTO));
                return true;
            }
            return false;
        }

        public bool Update(TimeFrameDTO TimeFrameDTO)
        {
            var updateTim = addContext.TimeFrames.Find(TimeFrameDTO.TimeFrameID);
            if (updateTim != null)
            {
                addContext.TimeFrames.Update(admap.Map(TimeFrameDTO, updateTim));
                return true;
            }
            return false;
        }

        public bool Delete(int TimeFrameID)
        {
            var DeleteTim = addContext.TimeFrames.Find(TimeFrameID);
            if (DeleteTim == null)
            {
                return false;
            }
            addContext.Remove(DeleteTim);
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

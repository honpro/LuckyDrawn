using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface iTimeFrameRepository
    {
        IEnumerable<TimeFrame> GetAll();
        TimeFrame GetById(int TimeFrameID);
        void Insert(TimeFrame TimeFrame);
        void Update(TimeFrame TimeFrame);
        void Delete(int TimeFrameID);
        void Save();
    }
}

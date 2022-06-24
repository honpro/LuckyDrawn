using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface iTimeFrameRepository
    {
        List<TimeFrameDTO> GetAll();
        TimeFrameDTO GetById(int TimeFrameID);
        bool Insert(TimeFrameDTO TimeFrameDTO);
        bool Update(TimeFrameDTO TimeFrameDTO);
        bool Delete(int TimeFrameID);
        void Save();
    }
}

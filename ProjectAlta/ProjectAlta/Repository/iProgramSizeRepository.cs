using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface IProgramSizeRepository
    {
        List<ProgramSizeDTO> GetAll();
        ProgramSizeDTO GetById(int ProgramSizeID);
        bool Insert(ProgramSizeDTO ProgramSizeDTO);
        bool Update(ProgramSizeDTO ProgramSizeDTO);
        bool Delete(int ProgramSizeID);
        void Save();
    }
}

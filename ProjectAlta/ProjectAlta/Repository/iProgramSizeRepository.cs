using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface iProgramSizeRepository
    {
        IEnumerable<ProgramSize> GetAll();
        ProgramSize GetById(int ProgramSizeID);
        void Insert(ProgramSize ProgramSize);
        void Update(ProgramSize ProgramSize);
        void Delete(int ProgramSizeID);
        void Save();
    }
}

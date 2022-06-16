using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface iCodeDetailRepository
    {
        IEnumerable<CodeDetail> GetAll();
        CodeDetail GetById(int CodeDetailID);
        void Insert(CodeDetail codeDetail);
        void Update(CodeDetail codeDetail);
        void Delete(int CodeDetailID);
        void Save();
    }
}

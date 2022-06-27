using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface ICodeDetailRepository
    {
        List<CodeDetailDTO> GetAll();
        CodeDetailDTO GetById(int CodeDetailID);
        bool Insert(CodeDetailDTO codeDetailDTO);
        bool Update(CodeDetailDTO codeDetailDTO);
        bool Delete(int CodeDetailID);
        void Save();
    }
}


using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface ITypeCodeRepository
    {
        List<TypeCodeDTO> GetAll();
        TypeCodeDTO GetById(int TypeCodeID);
        bool Insert(TypeCodeDTO TypeCodeDTO);
        bool Update(TypeCodeDTO TypeCodeDTO);
        bool Delete(int TypeCodeID);
        void Save();
    }
}

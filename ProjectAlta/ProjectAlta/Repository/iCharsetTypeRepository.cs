using ProjectAlta.DTO;
using ProjectAlta.Entity;
using System.Collections.Generic;
namespace ProjectAlta.Repository
{
    public interface ICharsetTypeRepository
    {
        List<CharsetTypeDTO> GetAll();
        CharsetTypeDTO GetById(int charsetTypeID);
        bool Insert(CharsetTypeDTO charsetTypeDTO);
        bool Update(CharsetTypeDTO charsetTypeDTO);
        bool Delete(int charsetTypeID);
        void Save();
    }
}

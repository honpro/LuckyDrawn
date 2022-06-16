using ProjectAlta.Entity;
using System.Collections.Generic;
namespace ProjectAlta.Repository
{
    public interface iCharsetTypeRepository
    {
        IEnumerable<CharsetType> GetAll();
        CharsetType GetById(int charsetTypeID);
        void Insert(CharsetType charsetType);
        void Update(CharsetType charsetType);
        void Delete(int charsetTypeID);
        void Save();
    }
}

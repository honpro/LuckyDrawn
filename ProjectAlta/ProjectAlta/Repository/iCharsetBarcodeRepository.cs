using ProjectAlta.DTO;
using ProjectAlta.Entity;
using System.Collections.Generic;
namespace ProjectAlta.Repository
{
    public interface ICharsetBarcodeRepository
    {
        List <CharsetBarcodeDTO> GetAll();
        CharsetBarcodeDTO GetById(int CharsetBarcodeID);
        bool Insert(CharsetBarcodeDTO charsetBarcodeDTO);
        bool Update(CharsetBarcodeDTO charsetBarcodeDTO);
        bool Delete(int CharsetBarcodeID);
        void Save();
    }
}

using ProjectAlta.DTO;
using ProjectAlta.Entity;
using System.Collections.Generic;
namespace ProjectAlta.Repository
{
    public interface IBarcodeRepository
    {
        List<BarcodeDTO> GetAll();
        BarcodeDTO GetById(int BarcodeID);
        bool Insert(BarcodeDTO barcode);
        bool Update(BarcodeDTO barcode);
        bool Delete(int BarcodeID);
        void Save();
    }
}

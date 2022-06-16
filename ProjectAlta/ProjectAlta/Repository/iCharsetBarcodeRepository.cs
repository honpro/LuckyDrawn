using ProjectAlta.Entity;
using System.Collections.Generic;
namespace ProjectAlta.Repository
{
    public interface iCharsetBarcodeRepository
    {
        IEnumerable <CharsetBarcode> GetAll();
        CharsetBarcode GetById(int CharsetBarcodeID);
        void Insert(CharsetBarcode charsetBarcode);
        void Update(CharsetBarcode charsetBarcode);
        void Delete(int CharsetBarcodeID);
        void Save();
    }
}

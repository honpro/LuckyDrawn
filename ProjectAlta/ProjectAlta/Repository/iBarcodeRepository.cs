using ProjectAlta.Entity;
using System.Collections.Generic;
namespace ProjectAlta.Repository
{
    public interface iBarcodeRepository
    {
        IEnumerable<Barcode> GetAll();
        Barcode GetById(int BarcodeID);
        void Insert(Barcode barcode);
        void Update(Barcode barcode);
        void Delete(int BarcodeID);
        void Save();
    }
}

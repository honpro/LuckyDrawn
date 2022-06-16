using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface iTypeBarcodeRepository
    {
        IEnumerable<TypeBarcode> GetAll();
        TypeBarcode GetById(int TypeBarcodeID);
        void Insert(TypeBarcode TypeBarcode);
        void Update(TypeBarcode TypeBarcode);
        void Delete(int TypeBarcodeID);
        void Save();
    }
}

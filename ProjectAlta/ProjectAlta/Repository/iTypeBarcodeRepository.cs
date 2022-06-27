using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface ITypeBarcodeRepository
    {
        List<TypeBarcodeDTO> GetAll();
        TypeBarcodeDTO GetById(int TypeBarcodeID);
        bool Insert(TypeBarcodeDTO TypeBarcodeDTO);
        bool Update(TypeBarcodeDTO TypeBarcodeDTO);
        bool Delete(int TypeBarcodeID);
        void Save();
    }
}

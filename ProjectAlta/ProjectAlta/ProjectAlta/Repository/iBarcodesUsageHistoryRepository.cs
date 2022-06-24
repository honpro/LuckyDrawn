using ProjectAlta.DTO;
using ProjectAlta.Entity;
using System.Collections.Generic;
namespace ProjectAlta.Repository
{
    
    public interface iBarcodesUsageHistoryRepository
    {
        List<BarcodesUsageHistoryDTO> GetAll();
        BarcodesUsageHistoryDTO GetById(int BarcodesUsageHistoryID);
        bool Insert(BarcodesUsageHistoryDTO barcodesUsageHistoryDTO);
        bool Update(BarcodesUsageHistoryDTO barcodesUsageHistoryDTO);
        bool Delete(int BarcodesUsageHistoryID);
        void Save();
    }
}

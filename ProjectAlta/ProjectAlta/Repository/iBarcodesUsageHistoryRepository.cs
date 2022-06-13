using ProjectAlta.Entity;
using System.Collections.Generic;
namespace ProjectAlta.Repository
{
    
    public interface iBarcodesUsageHistoryRepository
    {
        IEnumerable<BarcodesUsageHistory> GetAll();
        BarcodesUsageHistory GetById(int BarcodesUsageHistoryID);
        void Insert(BarcodesUsageHistory barcodesUsageHistory);
        void Update(BarcodesUsageHistory barcodesUsageHistory);
        void Delete(int BarcodesUsageHistoryID);
        void Save();
    }
}

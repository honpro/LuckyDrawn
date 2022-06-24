using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class BarcodesUsageHistoryRepository : iBarcodesUsageHistoryRepository
    {
        private readonly AddContext addContext;
        private readonly IMapper admap;

        public BarcodesUsageHistoryRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }
        

        public List<BarcodesUsageHistoryDTO> GetAll()
        {
           var allBarHis = addContext.BarcodesUsageHistories.ToList();
            return admap.Map<List<BarcodesUsageHistoryDTO>>(allBarHis);
        }

        public BarcodesUsageHistoryDTO GetById(int BarcodesUsageHistoryID)
        {
            var byid = addContext.BarcodesUsageHistories.Find(BarcodesUsageHistoryID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<BarcodesUsageHistoryDTO>(byid);
        }

        public bool Insert(BarcodesUsageHistoryDTO barcodesUsageHistoryDTO)
        {
            var insertBarHis = addContext.BarcodesUsageHistories.Find(barcodesUsageHistoryDTO.BarcodeID);
            if (insertBarHis == null)
            {
                addContext.BarcodesUsageHistories.Add(admap.Map<BarcodesUsageHistory>(barcodesUsageHistoryDTO));
                return true;
            }
            return false;
        }

        public bool Update(BarcodesUsageHistoryDTO barcodesUsageHistoryDTO)
        {
            var updateBarHis = addContext.BarcodesUsageHistories.Find(barcodesUsageHistoryDTO.BarcodeID);
            if (updateBarHis != null)
            {
                addContext.BarcodesUsageHistories.Update(admap.Map(barcodesUsageHistoryDTO, updateBarHis));
                return true;
            }
            return false;
        }

        public bool Delete(int BarcodesUsageHistoryID)
        {
            var DeleteBarHis = addContext.BarcodesUsageHistories.Find(BarcodesUsageHistoryID);
            if (DeleteBarHis == null)
            {
                return false;
            }
            addContext.Remove(DeleteBarHis);
            return true;
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    addContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

    }
}

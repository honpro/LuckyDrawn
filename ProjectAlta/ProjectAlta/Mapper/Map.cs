using AutoMapper;
using ProjectAlta.DTO;
using ProjectAlta.Entity;
namespace ProjectAlta.Mapper
{
    public class Map : Profile
    {
        public Map()
        {
            this.CreateMap <AccountDTO, Account>();
            this.CreateMap<Account, AccountDTO>();
            this.CreateMap<BarcodeDTO, Barcode>();
            this.CreateMap<Barcode, BarcodeDTO>();
            this.CreateMap<BarcodesUsageHistoryDTO, BarcodesUsageHistory>();
            this.CreateMap<BarcodesUsageHistory, BarcodesUsageHistoryDTO>();
            this.CreateMap<CodeDetailDTO, CodeDetail>();
            this.CreateMap<CodeDetail, CodeDetailDTO>();
        }
    }
}

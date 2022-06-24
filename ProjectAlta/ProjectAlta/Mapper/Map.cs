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
            this.CreateMap<CustomerDTO, Customer>();
            this.CreateMap<Customer, CustomerDTO>();
            this.CreateMap<CustomerPypeDTO, CustomerType>();
            this.CreateMap<CustomerType, CustomerPypeDTO>();
            this.CreateMap<CustomerTypeofBussinessDTO, CustomerTypeofBussiness>();
            this.CreateMap<CustomerTypeofBussiness, CustomerTypeofBussinessDTO>();
            this.CreateMap<GiftDTO, Gift>();
            this.CreateMap<Gift, GiftDTO>();
            this.CreateMap<GiftsOfCampignDTO, GiftsOfCampign>();
            this.CreateMap<GiftsOfCampign, GiftsOfCampignDTO>();
            this.CreateMap<ProgramSizeDTO, ProgramSize>();
            this.CreateMap<ProgramSize, ProgramSizeDTO>();
            this.CreateMap<RulesForGiftDTO, RulesForGift>();
            this.CreateMap<RulesForGift, RulesForGiftDTO>();
            this.CreateMap<SettingDTO, Setting>();
            this.CreateMap<Setting, SettingDTO>();  
            this.CreateMap<TimeFrameDTO, TimeFrame>();
            this.CreateMap<TimeFrame, TimeFrameDTO>();
            this.CreateMap<TypeBarcodeDTO, TypeBarcode>();
            this.CreateMap<TypeBarcode, TypeBarcodeDTO>();
            this.CreateMap<TypeCodeDTO, Entity.TypeCode >();
            this.CreateMap<Entity.TypeCode, TypeCodeDTO>();
        }
    }
}

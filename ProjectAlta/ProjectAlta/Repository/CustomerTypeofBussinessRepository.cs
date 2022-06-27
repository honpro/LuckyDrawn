using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class CustomerTypeofBussinessRepository : ICustomerTypeofBussinessRepository
    {
        private readonly AddContext addContext;
        private readonly IMapper admap;

        public CustomerTypeofBussinessRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }

        public bool Delete(int CustomerTypeofBussinessID)
        {
            var DeleteCus = addContext.CustomerTypeofBussinesses.Find(CustomerTypeofBussinessID);
            if (DeleteCus == null)
            {
                return false;
            }
            addContext.Remove(DeleteCus);
            return true;
        }

        public List<CustomerTypeofBussinessDTO> GetAll()
        {
            var allCus = addContext.CustomerTypeofBussinesses.ToList();
            return admap.Map<List<CustomerTypeofBussinessDTO>>(allCus);
        }

        public CustomerTypeofBussinessDTO GetById(int CustomerTypeofBussinessID)
        {
            var byid = addContext.CustomerTypeofBussinesses.Find(CustomerTypeofBussinessID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<CustomerTypeofBussinessDTO>(byid);
        }

        public bool Insert(CustomerTypeofBussinessDTO CustomerTypeofBussinessDTO)
        {
            var insertCus = addContext.CustomerTypeofBussinesses.Find((CustomerTypeofBussinessDTO.CustomerTypeofBussinessID));
            if (insertCus == null)
            {
                addContext.CustomerTypeofBussinesses.Add(admap.Map<CustomerTypeofBussiness>((CustomerTypeofBussinessDTO)));
                return true;
            }
            return false;
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public bool Update(CustomerTypeofBussinessDTO CustomerTypeofBussinessDTO)
        {
            var updateCus = addContext.CustomerTypeofBussinesses.Find(CustomerTypeofBussinessDTO.CustomerTypeofBussinessID);
            if (updateCus != null)
            {
                addContext.CustomerTypeofBussinesses.Update(admap.Map(CustomerTypeofBussinessDTO, updateCus));
                return true;
            }
            return false;
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

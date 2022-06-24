using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public class CustomerTypeRepository : iCustomerTypeRepository
    {
        private readonly AddContext addContext;
        private readonly IMapper admap;

        public CustomerTypeRepository(AddContext addcon, IMapper mapper)
        {
            addContext = addcon;
            admap = mapper;
        }

        public List<CustomerPypeDTO> GetAll()
        {
            var allCus = addContext.CustomerTypes.ToList();
            return admap.Map<List<CustomerPypeDTO>>(allCus);
        }

        public CustomerPypeDTO GetById(int CustomerTypeID)
        {
            var byid = addContext.CustomerTypes.Find(CustomerTypeID);
            if (byid == null)
            {
                return null;
            }
            return admap.Map<CustomerPypeDTO>(byid);
        }

        public bool Insert(CustomerPypeDTO CustomerTypeDTO)
        {
            var insertCus = addContext.CustomerTypes.Find(CustomerTypeDTO.CustomerPypeID);
            if (insertCus == null)
            {
                addContext.CustomerTypes.Add(admap.Map<CustomerType>(CustomerTypeDTO));
                return true;
            }
            return false;
        }

        public bool Update(CustomerPypeDTO CustomerTypeDTO)
        {
            var updateCus = addContext.CustomerTypes.Find(CustomerTypeDTO.CustomerPypeID);
            if (updateCus != null)
            {
                addContext.CustomerTypes.Update(admap.Map(CustomerTypeDTO, updateCus));
                return true;
            }
            return false;
        }

        public bool Delete(int CustomerTypeID)
        {
            var DeleteCus = addContext.CustomerTypes.Find(CustomerTypeID);
            if (DeleteCus == null)
            {
                return false;
            }
            addContext.Remove(DeleteCus);
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

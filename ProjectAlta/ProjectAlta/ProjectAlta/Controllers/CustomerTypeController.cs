using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerTypeController : ControllerBase
    {
        public readonly iCustomerTypeRepository iCustomerTypeRepository;

        public CustomerTypeController(AddContext addcon)
        {
            iCustomerTypeRepository = new CustomerTypeRepository(addcon);
        }
        [HttpGet]
        public ActionResult<IEnumerable<CustomerType>> Index()
        {
            var model = iCustomerTypeRepository.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddCustomerType(CustomerType model)
        {
            if (ModelState.IsValid)
            {
                iCustomerTypeRepository.Insert(model);
                iCustomerTypeRepository.Save();
            }
        }

        [HttpPost]
        public ActionResult<bool> EditCustomerType(CustomerType model)
        {
            if (ModelState.IsValid)
            {
                iCustomerTypeRepository.Update(model);
                iCustomerTypeRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<bool> Delete(int CustomerTypeID)
        {
            if (iCustomerTypeRepository.GetById(CustomerTypeID) != null)
            {
                iCustomerTypeRepository.Delete(CustomerTypeID);
                iCustomerTypeRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

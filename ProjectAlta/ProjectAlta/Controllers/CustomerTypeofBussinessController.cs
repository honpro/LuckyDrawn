using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerTypeofBussinessController : ControllerBase
    {
        public readonly iCustomerTypeofBussinessRepository iCustomerTypeofBussinessRepository;

        public CustomerTypeofBussinessController(AddContext addcon)
        {
            iCustomerTypeofBussinessRepository = new CustomerTypeofBussinessRepository(addcon);
        }
        [HttpGet]
        public ActionResult<IEnumerable<CustomerTypeofBussiness>> Index()
        {
            var model = iCustomerTypeofBussinessRepository.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddCustomerTypeofBussiness(CustomerTypeofBussiness model)
        {
            if (ModelState.IsValid)
            {
                iCustomerTypeofBussinessRepository.Insert(model);
                iCustomerTypeofBussinessRepository.Save();
            }
        }

        [HttpPost]
        public ActionResult<bool> EditCustomerTypeofBussiness(CustomerTypeofBussiness model)
        {
            if (ModelState.IsValid)
            {
                iCustomerTypeofBussinessRepository.Update(model);
                iCustomerTypeofBussinessRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<bool> Delete(int CustomerTypeofBussinessID)
        {
            if (iCustomerTypeofBussinessRepository.GetById(CustomerTypeofBussinessID) != null)
            {
                iCustomerTypeofBussinessRepository.Delete(CustomerTypeofBussinessID);
                iCustomerTypeofBussinessRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

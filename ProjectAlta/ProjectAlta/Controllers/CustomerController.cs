using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public readonly iCustomerRepository iCustomerRepository;

        public CustomerController(AddContext addcon)
        {
            iCustomerRepository = new CustomerRepository(addcon);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Index()
        {
            var model = iCustomerRepository.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddCustomer(Customer model)
        {
            if (ModelState.IsValid)
            {
                iCustomerRepository.Insert(model);
                iCustomerRepository.Save();
            }
        }

        [HttpPost]
        public ActionResult<bool> EditCustomer(Customer model)
        {
            if (ModelState.IsValid)
            {
                iCustomerRepository.Update(model);
                iCustomerRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<bool> Delete(int CustomerID)
        {
            if (iCustomerRepository.GetById(CustomerID) != null)
            {
                iCustomerRepository.Delete(CustomerID);
                iCustomerRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.DTO;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public readonly ICustomerRepository iCustomerRepository;
        private IMapper admap;


        public CustomerController(ICustomerRepository addcon, IMapper mapper)
        {
            iCustomerRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CustomerDTO>>> getAdmin()
        {
            var model = iCustomerRepository.GetAll();
            if (model == null)
            {
                return new List<CustomerDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddCus(CustomerDTO model)
        {
            var check = iCustomerRepository.Insert(model);
            iCustomerRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateCus(CustomerDTO model)
        {
            var check = iCustomerRepository.Update(model);
            iCustomerRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteCus(int id)
        {
            var check = iCustomerRepository.Delete(id);

            iCustomerRepository.Save();
            return check;

        }
    }
}

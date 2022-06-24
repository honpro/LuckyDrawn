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
    public class CustomerTypeController : ControllerBase
    {
        public readonly iCustomerTypeRepository iCustomerTypeRepository;
        private IMapper admap;


        public CustomerTypeController(iCustomerTypeRepository addcon, IMapper mapper)
        {
            iCustomerTypeRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CustomerPypeDTO>>> getAdmin()
        {
            var model = iCustomerTypeRepository.GetAll();
            if (model == null)
            {
                return new List<CustomerPypeDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddCus(CustomerPypeDTO model)
        {
            var check = iCustomerTypeRepository.Insert(model);
            iCustomerTypeRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateCus(CustomerPypeDTO model)
        {
            var check = iCustomerTypeRepository.Update(model);
            iCustomerTypeRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteCus(int id)
        {
            var check = iCustomerTypeRepository.Delete(id);

            iCustomerTypeRepository.Save();
            return check;

        }
    }
}

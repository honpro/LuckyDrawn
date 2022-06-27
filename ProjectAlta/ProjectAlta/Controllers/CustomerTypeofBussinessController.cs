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
    public class CustomerTypeofBussinessController : ControllerBase
    {
        public readonly ICustomerTypeofBussinessRepository iCustomerTypeofBussinessRepository;
        private IMapper admap;
      public CustomerTypeofBussinessController(ICustomerTypeofBussinessRepository addcon, IMapper mapper)
        {
            iCustomerTypeofBussinessRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CustomerTypeofBussinessDTO>>> getAdmin()
        {
            var model = iCustomerTypeofBussinessRepository.GetAll();
            if (model == null)
            {
                return new List<CustomerTypeofBussinessDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddCus(CustomerTypeofBussinessDTO model)
        {
            var check = iCustomerTypeofBussinessRepository.Insert(model);
            iCustomerTypeofBussinessRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateCus(CustomerTypeofBussinessDTO model)
        {
            var check = iCustomerTypeofBussinessRepository.Update(model);
            iCustomerTypeofBussinessRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteCus(int id)
        {
            var check = iCustomerTypeofBussinessRepository.Delete(id);

            iCustomerTypeofBussinessRepository.Save();
            return check;

        }
    }
}

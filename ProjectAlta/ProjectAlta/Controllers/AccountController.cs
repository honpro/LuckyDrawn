using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Repository;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using AutoMapper;
using ProjectAlta.DTO;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository iAccountRepository;
        private IMapper admap;
        public AccountController(IAccountRepository addcon, IMapper mapper)
        {
            iAccountRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<AccountDTO>>> getAdmin()
        {
            var model = iAccountRepository.GetAll();
            if (model == null)
            {
                return new List<AccountDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddAccount(AccountDTO model)
        {
            var check = iAccountRepository.Insert(model);
            iAccountRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateAccount(AccountDTO model)
        {
            var check = iAccountRepository.Update(model);
           iAccountRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteAccount(int id)
        {
            var check = iAccountRepository.Delete(id);

            iAccountRepository.Save();
            return check;

        }
    }
}

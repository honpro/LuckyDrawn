using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Repository;
using ProjectAlta.Context;
using ProjectAlta.Entity;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly iAccountRepository iAccountReponsitory;
        public AccountController(AddContext addcon)
        {
            iAccountReponsitory = new AccountRepository(addcon);
        }

        [HttpGet]
        public ActionResult <IEnumerable <Account>> Index()
        {
            var model = iAccountReponsitory.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddAccount( Account model)
        {
            if (ModelState.IsValid)
            {
                iAccountReponsitory.Insert(model);
                iAccountReponsitory.Save();              
            }        
        }

        [HttpPost]
        public ActionResult <bool> EditAccount(Account model)
        {
            if (ModelState.IsValid)
            {
                iAccountReponsitory.Update(model);
                iAccountReponsitory.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
        
        [HttpPost]
        public ActionResult <bool>  Delete(int AccountID)
        {
            if (iAccountReponsitory.GetById(AccountID) != null)
                {
                iAccountReponsitory.Delete(AccountID);
                iAccountReponsitory.Save();
                return true;
            }
              else
            {
                return false;
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RulesForGiftController : ControllerBase
    {
        public readonly iRulesForGiftRepository iRulesForGiftRepository;

        public RulesForGiftController(AddContext addcon)
        {
            iRulesForGiftRepository = new RulesForGiftRepository(addcon);
        }
        [HttpGet]
        public ActionResult<IEnumerable<RulesForGift>> Index()
        {
            var model = iRulesForGiftRepository.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddRulesForGift(RulesForGift model)
        {
            if (ModelState.IsValid)
            {
                iRulesForGiftRepository.Insert(model);
                iRulesForGiftRepository.Save();
            }
        }

        [HttpPost]
        public ActionResult<bool> EditRulesForGift(RulesForGift model)
        {
            if (ModelState.IsValid)
            {
                iRulesForGiftRepository.Update(model);
                iRulesForGiftRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<bool> Delete(int RulesForGiftID)
        {
            if (iRulesForGiftRepository.GetById(RulesForGiftID) != null)
            {
                iRulesForGiftRepository.Delete(RulesForGiftID);
                iRulesForGiftRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

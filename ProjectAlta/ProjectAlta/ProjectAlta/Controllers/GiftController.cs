using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiftController : ControllerBase
    {
        public readonly iGiftRepository iGiftRepository;

        public GiftController(AddContext addcon)
        {
            iGiftRepository = new GiftRepository(addcon);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Gift>> Index()
        {
            var model = iGiftRepository.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddGift(Gift model)
        {
            if (ModelState.IsValid)
            {
                iGiftRepository.Insert(model);
                iGiftRepository.Save();
            }
        }

        [HttpPost]
        public ActionResult<bool> EditGift(Gift model)
        {
            if (ModelState.IsValid)
            {
                iGiftRepository.Update(model);
                iGiftRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<bool> Delete(int GiftID)
        {
            if (iGiftRepository.GetById(GiftID) != null)
            {
                iGiftRepository.Delete(GiftID);
                iGiftRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

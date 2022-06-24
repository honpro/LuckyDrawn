using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiftsOfCampignController : ControllerBase
    {
        public readonly iGiftsOfCampignRepository iGiftsOfCampignRepository;

        public GiftsOfCampignController(AddContext addcon)
        {
            iGiftsOfCampignRepository = new GiftsOfCampignRepository(addcon);
        }
        [HttpGet]
        public ActionResult<IEnumerable<GiftsOfCampign>> Index()
        {
            var model = iGiftsOfCampignRepository.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddGiftsOfCampign(GiftsOfCampign model)
        {
            if (ModelState.IsValid)
            {
                iGiftsOfCampignRepository.Insert(model);
                iGiftsOfCampignRepository.Save();
            }
        }

        [HttpPost]
        public ActionResult<bool> EditGiftsOfCampign(GiftsOfCampign model)
        {
            if (ModelState.IsValid)
            {
                iGiftsOfCampignRepository.Update(model);
                iGiftsOfCampignRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<bool> Delete(int GiftsOfCampignID)
        {
            if (iGiftsOfCampignRepository.GetById(GiftsOfCampignID) != null)
            {
                iGiftsOfCampignRepository.Delete(GiftsOfCampignID);
                iGiftsOfCampignRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

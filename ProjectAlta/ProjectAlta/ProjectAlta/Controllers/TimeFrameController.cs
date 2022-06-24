using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeFrameController : ControllerBase
    {
        public readonly iTimeFrameRepository iTimeFrameRepository;

        public TimeFrameController(AddContext addcon)
        {
            iTimeFrameRepository = new TimeFrameRepository(addcon);
        }
        [HttpGet]
        public ActionResult<IEnumerable<TimeFrame>> Index()
        {
            var model = iTimeFrameRepository.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddTimeFrame(TimeFrame model)
        {
            if (ModelState.IsValid)
            {
                iTimeFrameRepository.Insert(model);
                iTimeFrameRepository.Save();
            }
        }

        [HttpPost]
        public ActionResult<bool> EditTimeFrame(TimeFrame model)
        {
            if (ModelState.IsValid)
            {
                iTimeFrameRepository.Update(model);
                iTimeFrameRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<bool> Delete(int TimeFrameID)
        {
            if (iTimeFrameRepository.GetById(TimeFrameID) != null)
            {
                iTimeFrameRepository.Delete(TimeFrameID);
                iTimeFrameRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

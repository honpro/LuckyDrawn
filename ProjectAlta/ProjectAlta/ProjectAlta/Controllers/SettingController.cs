using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingController : ControllerBase
    {
        public readonly iSettingRepository iSettingRepository;

        public SettingController(AddContext addcon)
        {
            iSettingRepository = new SettingRepository(addcon);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Setting>> Index()
        {
            var model = iSettingRepository.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddSetting(Setting model)
        {
            if (ModelState.IsValid)
            {
                iSettingRepository.Insert(model);
                iSettingRepository.Save();
            }
        }

        [HttpPost]
        public ActionResult<bool> EditSetting(Setting model)
        {
            if (ModelState.IsValid)
            {
                iSettingRepository.Update(model);
                iSettingRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<bool> Delete(int SettingID)
        {
            if (iSettingRepository.GetById(SettingID) != null)
            {
                iSettingRepository.Delete(SettingID);
                iSettingRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

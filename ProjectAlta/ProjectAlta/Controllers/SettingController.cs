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
    public class SettingController : ControllerBase
    {
        public readonly iSettingRepository iSettingRepository;
        private IMapper admap;
        public SettingController(iSettingRepository addcon, IMapper mapper)
        {
            iSettingRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<SettingDTO>>> getAdmin()
        {
            var model = iSettingRepository.GetAll();
            if (model == null)
            {
                return new List<SettingDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddSet(SettingDTO model)
        {
            var check = iSettingRepository.Insert(model);
            iSettingRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateSet(SettingDTO model)
        {
            var check = iSettingRepository.Update(model);
            iSettingRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteSet(int id)
        {
            var check = iSettingRepository.Delete(id);

            iSettingRepository.Save();
            return check;

        }
    }
}

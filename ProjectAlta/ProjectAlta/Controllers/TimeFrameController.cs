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
    public class TimeFrameController : ControllerBase
    {
        public readonly iTimeFrameRepository iTimeFrameRepository;
        private IMapper admap;
        public TimeFrameController(iTimeFrameRepository addcon, IMapper mapper)
        {
            iTimeFrameRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<TimeFrameDTO>>> getAdmin()
        {
            var model = iTimeFrameRepository.GetAll();
            if (model == null)
            {
                return new List<TimeFrameDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddTim(TimeFrameDTO model)
        {
            var check = iTimeFrameRepository.Insert(model);
            iTimeFrameRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateTim(TimeFrameDTO model)
        {
            var check = iTimeFrameRepository.Update(model);
            iTimeFrameRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteTim(int id)
        {
            var check = iTimeFrameRepository.Delete(id);

            iTimeFrameRepository.Save();
            return check;

        }
    }
}

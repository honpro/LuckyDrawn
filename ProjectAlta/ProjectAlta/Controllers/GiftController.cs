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
    public class GiftController : ControllerBase
    {
        public readonly iGiftRepository iGiftRepository;
        private IMapper admap;
        public GiftController(iGiftRepository addcon, IMapper mapper)
        {
            iGiftRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<GiftDTO>>> getAdmin()
        {
            var model = iGiftRepository.GetAll();
            if (model == null)
            {
                return new List<GiftDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddGif(GiftDTO model)
        {
            var check = iGiftRepository.Insert(model);
            iGiftRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateGif(GiftDTO model)
        {
            var check = iGiftRepository.Update(model);
            iGiftRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteGif(int id)
        {
            var check = iGiftRepository.Delete(id);

            iGiftRepository.Save();
            return check;

        }
    }
}

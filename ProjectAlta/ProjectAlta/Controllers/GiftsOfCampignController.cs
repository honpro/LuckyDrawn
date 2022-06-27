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
    public class GiftsOfCampignController : ControllerBase
    {
        public readonly IGiftsOfCampignRepository iGiftsOfCampignRepository;
        private IMapper admap;
        public GiftsOfCampignController(IGiftsOfCampignRepository addcon, IMapper mapper)
        {
            iGiftsOfCampignRepository= addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<GiftsOfCampignDTO>>> getAdmin()
        {
            var model = iGiftsOfCampignRepository.GetAll();
            if (model == null)
            {
                return new List<GiftsOfCampignDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddGif(GiftsOfCampignDTO model)
        {
            var check = iGiftsOfCampignRepository.Insert(model);
            iGiftsOfCampignRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateGif(GiftsOfCampignDTO model)
        {
            var check = iGiftsOfCampignRepository.Update(model);
            iGiftsOfCampignRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteGif(int id)
        {
            var check = iGiftsOfCampignRepository.Delete(id);

            iGiftsOfCampignRepository.Save();
            return check;

        }
    }
}

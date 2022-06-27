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
    public class CharsetBarcodeController : ControllerBase
    {
        public readonly ICharsetBarcodeRepository iCharsetBarcodeRepository;

        private IMapper admap;


        public CharsetBarcodeController(ICharsetBarcodeRepository addcon, IMapper mapper)
        {
            iCharsetBarcodeRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CharsetBarcodeDTO>>> getAdmin()
        {
            var model = iCharsetBarcodeRepository.GetAll();
            if (model == null)
            {
                return new List<CharsetBarcodeDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddCha(CharsetBarcodeDTO model)
        {
            var check = iCharsetBarcodeRepository.Insert(model);
            iCharsetBarcodeRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateCha(CharsetBarcodeDTO model)
        {
            var check = iCharsetBarcodeRepository.Update(model);
            iCharsetBarcodeRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteCha(int id)
        {
            var check = iCharsetBarcodeRepository.Delete(id);

            iCharsetBarcodeRepository.Save();
            return check;

        }
    }
}

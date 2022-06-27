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
    public class CharsetTypeController : ControllerBase
    {
        public readonly ICharsetTypeRepository iCharsetTypeRepository;
        private IMapper admap;


        public CharsetTypeController(ICharsetTypeRepository addcon, IMapper mapper)
        {
            iCharsetTypeRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CharsetTypeDTO>>> getAdmin()
        {
            var model = iCharsetTypeRepository.GetAll();
            if (model == null)
            {
                return new List<CharsetTypeDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddCha(CharsetTypeDTO model)
        {
            var check = iCharsetTypeRepository.Insert(model);
            iCharsetTypeRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateCha(CharsetTypeDTO model)
        {
            var check = iCharsetTypeRepository.Update(model);
            iCharsetTypeRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteCha(int id)
        {
            var check = iCharsetTypeRepository.Delete(id);

            iCharsetTypeRepository.Save();
            return check;

        }
    }
}

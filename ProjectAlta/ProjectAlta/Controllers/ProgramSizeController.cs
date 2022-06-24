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
    public class ProgramSizeController : ControllerBase
    {
        public readonly iProgramSizeRepository iProgramSizeRepository;
        private IMapper admap;
        public ProgramSizeController(iProgramSizeRepository addcon, IMapper mapper)
        {
            iProgramSizeRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProgramSizeDTO>>> getAdmin()
        {
            var model = iProgramSizeRepository.GetAll();
            if (model == null)
            {
                return new List<ProgramSizeDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddPro(ProgramSizeDTO model)
        {
            var check = iProgramSizeRepository.Insert(model);
            iProgramSizeRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdatePro(ProgramSizeDTO model)
        {
            var check = iProgramSizeRepository.Update(model);
            iProgramSizeRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeletePro(int id)
        {
            var check = iProgramSizeRepository.Delete(id);

            iProgramSizeRepository.Save();
            return check;

        }
    }
}

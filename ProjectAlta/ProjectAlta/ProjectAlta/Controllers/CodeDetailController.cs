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
    public class CodeDetailController : ControllerBase
    {
        public readonly iCodeDetailRepository iCodeDetailRepository;
        private IMapper admap;


        public CodeDetailController(iCodeDetailRepository addcon, IMapper mapper)
        {
            iCodeDetailRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CodeDetailDTO>>> getAdmin()
        {
            var model = iCodeDetailRepository.GetAll();
            if (model == null)
            {
                return new List<CodeDetailDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddCode(CodeDetailDTO model)
        {
            var check = iCodeDetailRepository.Insert(model);
            iCodeDetailRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateCode(CodeDetailDTO model)
        {
            var check = iCodeDetailRepository.Update(model);
            iCodeDetailRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteCode(int id)
        {
            var check = iCodeDetailRepository.Delete(id);

            iCodeDetailRepository.Save();
            return check;

        }
    }
}

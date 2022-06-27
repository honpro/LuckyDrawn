using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.DTO;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeCodeController : ControllerBase
    {
        public readonly ITypeCodeRepository iTypeCodeRepository;
        private IMapper admap;
        public TypeCodeController(ITypeCodeRepository addcon, IMapper mapper)
        {
            iTypeCodeRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<TypeCodeDTO>>> getAdmin()
        {
            var model = iTypeCodeRepository.GetAll();
            if (model == null)
            {
                return new List<TypeCodeDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddTyBa(TypeCodeDTO model)
        {
            var check = iTypeCodeRepository.Insert(model);
            iTypeCodeRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateTyBa(TypeCodeDTO model)
        {
            var check = iTypeCodeRepository.Update(model);
            iTypeCodeRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteTyBa(int id)
        {
            var check = iTypeCodeRepository.Delete(id);

            iTypeCodeRepository.Save();
            return check;

        }
    }
}

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
    public class RulesForGiftController : ControllerBase
    {
        public readonly iRulesForGiftRepository iRulesForGiftRepository;
        private IMapper admap;
        public RulesForGiftController(iRulesForGiftRepository addcon, IMapper mapper)
        {
            iRulesForGiftRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<RulesForGiftDTO>>> getAdmin()
        {
            var model = iRulesForGiftRepository.GetAll();
            if (model == null)
            {
                return new List<RulesForGiftDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddRu(RulesForGiftDTO model)
        {
            var check = iRulesForGiftRepository.Insert(model);
            iRulesForGiftRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateRu(RulesForGiftDTO model)
        {
            var check = iRulesForGiftRepository.Update(model);
            iRulesForGiftRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteRu(int id)
        {
            var check = iRulesForGiftRepository.Delete(id);

            iRulesForGiftRepository.Save();
            return check;

        }
    }
}

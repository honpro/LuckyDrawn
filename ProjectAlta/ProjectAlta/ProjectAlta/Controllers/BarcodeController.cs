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
    public class BarcodeController : ControllerBase
    {
        public readonly iBarcodeRepository iBarcodeRepository;
        private IMapper admap;
       
        
        public BarcodeController(iBarcodeRepository addcon, IMapper mapper)
        {
            iBarcodeRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<BarcodeDTO>>> getAdmin()
        {
            var model = iBarcodeRepository.GetAll();
            if (model == null)
            {
                return new List<BarcodeDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddBar(BarcodeDTO model)
        {
            var check = iBarcodeRepository.Insert(model);
            iBarcodeRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateBar(BarcodeDTO model)
        {
            var check = iBarcodeRepository.Update(model);
            iBarcodeRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteBar(int id)
        {
            var check = iBarcodeRepository.Delete(id);

            iBarcodeRepository.Save();
            return check;

        }
    }
}

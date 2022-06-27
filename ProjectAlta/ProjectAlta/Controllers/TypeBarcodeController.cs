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
    public class TypeBarcodeController : ControllerBase
    {
        public readonly ITypeBarcodeRepository iTypeBarcodeRepository;
        private IMapper admap;
        public TypeBarcodeController(ITypeBarcodeRepository addcon, IMapper mapper)
        {
            iTypeBarcodeRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<TypeBarcodeDTO>>> getAdmin()
        {
            var model = iTypeBarcodeRepository.GetAll();
            if (model == null)
            {
                return new List<TypeBarcodeDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddTyBa(TypeBarcodeDTO model)
        {
            var check = iTypeBarcodeRepository.Insert(model);
            iTypeBarcodeRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateTyBa(TypeBarcodeDTO model)
        {
            var check = iTypeBarcodeRepository.Update(model);
            iTypeBarcodeRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteTyBa(int id)
        {
            var check = iTypeBarcodeRepository.Delete(id);

            iTypeBarcodeRepository.Save();
            return check;

        }
    }
}

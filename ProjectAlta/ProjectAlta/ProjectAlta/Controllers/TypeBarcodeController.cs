using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeBarcodeController : ControllerBase
    {
        public readonly iTypeBarcodeRepository iTypeBarcodeRepository;

        public TypeBarcodeController(AddContext addcon)
        {
            iTypeBarcodeRepository = new TypeBarcodeRepository(addcon);
        }
        [HttpGet]
        public ActionResult<IEnumerable<TypeBarcode>> Index()
        {
            var model = iTypeBarcodeRepository.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddTypeBarcode(TypeBarcode model)
        {
            if (ModelState.IsValid)
            {
                iTypeBarcodeRepository.Insert(model);
                iTypeBarcodeRepository.Save();
            }
        }

        [HttpPost]
        public ActionResult<bool> EditTypeBarcode(TypeBarcode model)
        {
            if (ModelState.IsValid)
            {
                iTypeBarcodeRepository.Update(model);
                iTypeBarcodeRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<bool> Delete(int TypeBarcodeID)
        {
            if (iTypeBarcodeRepository.GetById(TypeBarcodeID) != null)
            {
                iTypeBarcodeRepository.Delete(TypeBarcodeID);
                iTypeBarcodeRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

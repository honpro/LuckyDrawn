using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharsetBarcodeController : ControllerBase
    {
        public readonly iCharsetBarcodeRepository iCharsetBarcodeRepository;

        public CharsetBarcodeController(AddContext addcon)
        {
            iCharsetBarcodeRepository = new CharsetBarcodeRepository(addcon);
        }
        [HttpGet]
        public ActionResult<IEnumerable<CharsetBarcode>> Index()
        {
            var model = iCharsetBarcodeRepository.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddCharsetBarcode(CharsetBarcode model)
        {
            if (ModelState.IsValid)
            {
                iCharsetBarcodeRepository.Insert(model);
                iCharsetBarcodeRepository.Save();
            }
        }

        [HttpPost]
        public ActionResult<bool> EditCharsetBarcode(CharsetBarcode model)
        {
            if (ModelState.IsValid)
            {
                iCharsetBarcodeRepository.Update(model);
                iCharsetBarcodeRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<bool> Delete(int CharsetBarcodeID)
        {
            if (iCharsetBarcodeRepository.GetById(CharsetBarcodeID) != null)
            {
                iCharsetBarcodeRepository.Delete(CharsetBarcodeID);
                iCharsetBarcodeRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

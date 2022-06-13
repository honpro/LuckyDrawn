using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarcodeController : ControllerBase
    {
        public readonly iBarcodeRepository iBarcodeRepository;

        public BarcodeController (AddContext addcon)
        {
            iBarcodeRepository = new BarcodesRepository(addcon);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Barcode>> Index()
        {
            var model = iBarcodeRepository.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddBarcode(Barcode model)
        {
            if (ModelState.IsValid)
            {
                iBarcodeRepository.Insert(model);
                iBarcodeRepository.Save();
            }
        }

        [HttpPost]
        public ActionResult<bool> EditBarcode(Barcode model)
        {
            if (ModelState.IsValid)
            {
                iBarcodeRepository.Update(model);
                iBarcodeRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<bool> Delete(int BarcodeID)
        {
            if (iBarcodeRepository.GetById(BarcodeID) != null)
            {
                iBarcodeRepository.Delete(BarcodeID);
                iBarcodeRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

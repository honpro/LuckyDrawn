 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarcodesUsageHistoryController : ControllerBase
    {
        public readonly iBarcodesUsageHistoryRepository iBarcodesUsageHistoryRepository;

        public BarcodesUsageHistoryController(AddContext addcon)
        {
            iBarcodesUsageHistoryRepository = new BarcodesUsageHistoryRepository(addcon);

        }
        [HttpGet]
        public ActionResult<IEnumerable<BarcodesUsageHistory>> Index()
        {
            var model = iBarcodesUsageHistoryRepository.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddBarcodeBarcodesUsageHistory(BarcodesUsageHistory model)
        {
            if (ModelState.IsValid)
            {
                iBarcodesUsageHistoryRepository.Insert(model);
                iBarcodesUsageHistoryRepository.Save();
            }
        }

        [HttpPost]
        public ActionResult<bool> EditBarcodesUsageHistory(BarcodesUsageHistory model)
        {
            if (ModelState.IsValid)
            {
                iBarcodesUsageHistoryRepository.Update(model);
                iBarcodesUsageHistoryRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<bool> Delete(int BarcodesUsageHistoryID)
        {
            if (iBarcodesUsageHistoryRepository.GetById(BarcodesUsageHistoryID) != null)
            {
                iBarcodesUsageHistoryRepository.Delete(BarcodesUsageHistoryID);
                iBarcodesUsageHistoryRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

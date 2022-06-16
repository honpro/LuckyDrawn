using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeDetailController : ControllerBase
    {
        public readonly iCodeDetailRepository iCodeDetailRepository;

        public CodeDetailController(AddContext addcon)
        {
            iCodeDetailRepository = new CodeDetailRepository(addcon);
        }
        [HttpGet]
        public ActionResult<IEnumerable<CodeDetail>> Index()
        {
            var model = iCodeDetailRepository.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddCodeDetail(CodeDetail model)
        {
            if (ModelState.IsValid)
            {
                iCodeDetailRepository.Insert(model);
                iCodeDetailRepository.Save();
            }
        }

        [HttpPost]
        public ActionResult<bool> EditCodeDetail(CodeDetail model)
        {
            if (ModelState.IsValid)
            {
                iCodeDetailRepository.Update(model);
                iCodeDetailRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<bool> Delete(int CodeDetailID)
        {
            if (iCodeDetailRepository.GetById(CodeDetailID) != null)
            {
                iCodeDetailRepository.Delete(CodeDetailID);
                iCodeDetailRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramSizeController : ControllerBase
    {
        public readonly iProgramSizeRepository iProgramSizeRepository;

        public ProgramSizeController(AddContext addcon)
        {
            iProgramSizeRepository = new ProgramSizeRepository(addcon);
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProgramSize>> Index()
        {
            var model = iProgramSizeRepository.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddProgramSize(ProgramSize model)
        {
            if (ModelState.IsValid)
            {
                iProgramSizeRepository.Insert(model);
                iProgramSizeRepository.Save();
            }
        }

        [HttpPost]
        public ActionResult<bool> EditProgramSize(ProgramSize model)
        {
            if (ModelState.IsValid)
            {
                iProgramSizeRepository.Update(model);
                iProgramSizeRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<bool> Delete(int ProgramSizeID)
        {
            if (iProgramSizeRepository.GetById(ProgramSizeID) != null)
            {
                iProgramSizeRepository.Delete(ProgramSizeID);
                iProgramSizeRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

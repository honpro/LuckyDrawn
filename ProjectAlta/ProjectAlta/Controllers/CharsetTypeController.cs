using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAlta.Context;
using ProjectAlta.Entity;
using ProjectAlta.Repository;

namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharsetTypeController : ControllerBase
    {
        public readonly iCharsetTypeRepository iCharsetTypeRepository;

        public CharsetTypeController(AddContext addcon)
        {
            iCharsetTypeRepository = new CharsetTypeRepository(addcon);
        }
        [HttpGet]
        public ActionResult<IEnumerable<CharsetType>> Index()
        {
            var model = iCharsetTypeRepository.GetAll();
            return model.ToList();
        }

        [HttpPost]
        public void AddCharsetType(CharsetType model)
        {
            if (ModelState.IsValid)
            {
                iCharsetTypeRepository.Insert(model);
                iCharsetTypeRepository.Save();
            }
        }

        [HttpPost]
        public ActionResult<bool> EditCharsetType(CharsetType model)
        {
            if (ModelState.IsValid)
            {
                iCharsetTypeRepository.Update(model);
                iCharsetTypeRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult<bool> Delete(int charsetTypeID)
        {
            if (iCharsetTypeRepository.GetById(charsetTypeID) != null)
            {
                iCharsetTypeRepository.Delete(charsetTypeID);
                iCharsetTypeRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

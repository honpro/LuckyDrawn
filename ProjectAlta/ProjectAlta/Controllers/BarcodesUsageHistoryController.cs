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
    public class BarcodesUsageHistoryController : ControllerBase
    {
        public readonly IBarcodesUsageHistoryRepository iBarcodesUsageHistoryRepository;

        private IMapper admap;


        public BarcodesUsageHistoryController(IBarcodesUsageHistoryRepository addcon, IMapper mapper)
        {
            iBarcodesUsageHistoryRepository = addcon;
            admap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<BarcodesUsageHistoryDTO>>> getAdmin()
        {
            var model = iBarcodesUsageHistoryRepository.GetAll();
            if (model == null)
            {
                return new List<BarcodesUsageHistoryDTO>();
            }
            return model.ToList();
        }


        [HttpPost]
        public ActionResult<bool> AddBarHis(BarcodesUsageHistoryDTO model)
        {
            var check = iBarcodesUsageHistoryRepository.Insert(model);
            iBarcodesUsageHistoryRepository.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateBarHis(BarcodesUsageHistoryDTO model)
        {
            var check = iBarcodesUsageHistoryRepository.Update(model);
            iBarcodesUsageHistoryRepository.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteBarHis(int id)
        {
            var check = iBarcodesUsageHistoryRepository.Delete(id);

            iBarcodesUsageHistoryRepository.Save();
            return check;

        }
    }
}

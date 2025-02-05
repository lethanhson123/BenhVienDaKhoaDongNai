using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System.Collections.Generic;

namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class GoiSoThamSoController : BaseController<GoiSoThamSo, IGoiSoThamSoService>
    {
        private readonly IGoiSoThamSoService _GoiSoThamSoService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public GoiSoThamSoController(IGoiSoThamSoService GoiSoThamSoService, IWebHostEnvironment WebHostEnvironment) : base(GoiSoThamSoService, WebHostEnvironment)
        {
            _GoiSoThamSoService = GoiSoThamSoService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("KhoiPhucAsync")]
        public virtual async Task<List<GoiSoThamSo>> KhoiPhucAsync()
        {
            List<GoiSoThamSo> result = new List<GoiSoThamSo>();
            try
            {
                result = await _GoiSoThamSoService.KhoiPhucAsync();
                foreach (GoiSoThamSo item in result)
                {
                    await _GoiSoThamSoService.SaveAsync(item);
                    result.Add(item);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}


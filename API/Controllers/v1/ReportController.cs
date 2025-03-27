using System.Security.Cryptography;

namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ReportController : BaseController<Report, IReportService>
    {
        private readonly IReportService _ReportService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ReportController(IReportService ReportService, IWebHostEnvironment WebHostEnvironment) : base(ReportService, WebHostEnvironment)
        {
            _ReportService = ReportService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("Report0001ToListAsync")]
        public async Task<List<Report>> Report0001ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ReportService.Report0001ToListAsync(model.ID);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("Report0002ToListAsync")]
        public async Task<List<Report>> Report0002ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ReportService.Report0002ToListAsync(model.ID);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("Report0003ToListAsync")]
        public async Task<List<Report>> Report0003ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ReportService.Report0003ToListAsync(model.ID);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("Report0004ToAsync")]
        public async Task<Report> Report0004ToAsync()
        {
            Report result = new Report();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ReportService.Report0004ToAsync(model.ThanhVienID.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("Report0005ToListAsync")]
        public async Task<List<Report>> Report0005ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ReportService.Report0005ToListAsync(model.ThanhVienID.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
       
    }
}


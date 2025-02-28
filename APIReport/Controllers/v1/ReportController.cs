namespace APIReport.Controllers.v1
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
        [Route("ReportDictionary0001ToListAsync")]
        public async Task<List<Report>> ReportDictionary0001ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {                
                result = await _ReportService.ReportDictionary0001ToListAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("ReportDictionary0002ToListAsync")]
        public async Task<List<Report>> ReportDictionary0002ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {
                result = await _ReportService.ReportDictionary0002ToListAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("ReportDictionary0003ToListAsync")]
        public async Task<List<Report>> ReportDictionary0003ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ReportService.ReportDictionary0003ToListAsync(baseParameter.Year.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("ReportA0001ToListAsync")]
        public async Task<List<Report>> ReportA0001ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ReportService.ReportA0001ToListAsync(baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.Day.Value, baseParameter.PhongBanID.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}


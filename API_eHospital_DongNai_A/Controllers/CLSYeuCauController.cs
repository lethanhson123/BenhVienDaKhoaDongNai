namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSYeuCauController : BaseController<CLSYeuCau, ICLSYeuCauService>
    {
        private readonly ICLSYeuCauService _CLSYeuCauService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public CLSYeuCauController(ICLSYeuCauService CLSYeuCauService, IWebHostEnvironment WebHostEnvironment) : base(CLSYeuCauService, WebHostEnvironment)
        {
            _CLSYeuCauService = CLSYeuCauService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByBenhNhan_Id_Year_Month_DayToListAsync")]
        public virtual async Task<List<CLSYeuCau>> GetByBenhNhan_Id_Year_Month_DayToListAsync()
        {
            List<CLSYeuCau> result = new List<CLSYeuCau>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _CLSYeuCauService.GetByBenhNhan_Id_Year_Month_DayToListAsync(baseParameter.BenhNhan_Id.Value, baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.Day.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}


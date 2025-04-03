namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThongKeController : BaseController<ThongKe, IThongKeService>
    {
        private readonly IThongKeService _ThongKeService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ThongKeController(IThongKeService ThongKeService, IWebHostEnvironment WebHostEnvironment) : base(ThongKeService, WebHostEnvironment)
        {
            _ThongKeService = ThongKeService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByParentID_Year_Month_DayAsync")]
        public virtual async Task<ThongKe> GetByParentID_Year_Month_DayAsync()
        {
            ThongKe result = new ThongKe();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ThongKeService.GetByParentID_Year_Month_DayAsync(baseParameter.ParentID.Value, baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.Day.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByParentID_Year_MonthAsync")]
        public virtual async Task<ThongKe> GetByParentID_Year_MonthAsync()
        {
            ThongKe result = new ThongKe();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ThongKeService.GetByParentID_Year_MonthAsync(baseParameter.ParentID.Value, baseParameter.Year.Value, baseParameter.Month.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
    }
}


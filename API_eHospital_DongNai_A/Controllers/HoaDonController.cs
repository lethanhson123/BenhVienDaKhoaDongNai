namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoaDonController : BaseController<HoaDon, IHoaDonService>
    {
        private readonly IHoaDonService _HoaDonService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public HoaDonController(IHoaDonService HoaDonService, IWebHostEnvironment WebHostEnvironment) : base(HoaDonService, WebHostEnvironment)
        {
            _HoaDonService = HoaDonService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByBenhNhan_Id_Year_Month_DayToListAsync")]
        public virtual async Task<List<HoaDon>> GetByBenhNhan_Id_Year_Month_DayToListAsync()
        {
            List<HoaDon> result = new List<HoaDon>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _HoaDonService.GetByBenhNhan_Id_Year_Month_DayToListAsync(baseParameter.BenhNhan_Id.Value, baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.Day.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}


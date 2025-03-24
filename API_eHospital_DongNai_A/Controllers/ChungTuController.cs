namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChungTuController : BaseController<ChungTu, IChungTuService>
    {
        private readonly IChungTuService _ChungTuService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ChungTuController(IChungTuService ChungTuService, IWebHostEnvironment WebHostEnvironment) : base(ChungTuService, WebHostEnvironment)
        {
            _ChungTuService = ChungTuService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByChungTu_IdAsync")]
        public virtual async Task<ChungTu> GetByChungTu_IdAsync()
        {
            ChungTu result = new ChungTu();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ChungTuService.GetByChungTu_IdAsync(baseParameter.ChungTu_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByNgayChungTu_SearchStringToListAsync")]
        public virtual async Task<List<ChungTu>> GetByNgayChungTu_SearchStringToListAsync()
        {
            List<ChungTu> result = new List<ChungTu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ChungTuService.GetByNgayChungTu_SearchStringToListAsync(baseParameter.NgayChungTu.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByYear_Month_Day_SearchStringToListAsync")]
        public virtual async Task<List<ChungTu>> GetByYear_Month_Day_SearchStringToListAsync()
        {
            List<ChungTu> result = new List<ChungTu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ChungTuService.GetByYear_Month_Day_SearchStringToListAsync(baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.Day.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByBenhNhan_Id_Year_Month_DayToListAsync")]
        public virtual async Task<List<ChungTu>> GetByBenhNhan_Id_Year_Month_DayToListAsync()
        {
            List<ChungTu> result = new List<ChungTu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ChungTuService.GetByBenhNhan_Id_Year_Month_DayToListAsync(baseParameter.BenhNhan_Id.Value, baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.Day.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}


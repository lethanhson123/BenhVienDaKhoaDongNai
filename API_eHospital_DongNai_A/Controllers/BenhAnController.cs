namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnController : BaseController<BenhAn, IBenhAnService>
    {
        private readonly IBenhAnService _BenhAnService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public BenhAnController(IBenhAnService BenhAnService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnService, WebHostEnvironment)
        {
            _BenhAnService = BenhAnService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByBenhAn_IdAsync")]
        public virtual async Task<BenhAn> GetByBenhAn_IdAsync()
        {
            BenhAn result = new BenhAn();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _BenhAnService.GetByBenhAn_IdAsync(baseParameter.BenhAn_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByBenhAn_IdToListAsync")]
        public virtual async Task<List<BenhAn>> GetByBenhAn_IdToListAsync()
        {
            List<BenhAn> result = new List<BenhAn>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _BenhAnService.GetByBenhAn_IdToListAsync(baseParameter.BenhAn_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetBySearchStringAsync")]
        public virtual async Task<BenhAn> GetBySearchStringAsync()
        {
            BenhAn result = new BenhAn();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _BenhAnService.GetBySearchStringAsync(baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByNgayVaoVien_SearchStringToListAsync")]
        public virtual async Task<List<BenhAn>> GetByNgayVaoVien_SearchStringToListAsync()
        {
            List<BenhAn> result = new List<BenhAn>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _BenhAnService.GetByNgayVaoVien_SearchStringToListAsync(baseParameter.NgayVaoVien.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByYear_Month_Day_SearchStringToListAsync")]
        public virtual async Task<List<BenhAn>> GetByYear_Month_Day_SearchStringToListAsync()
        {
            List<BenhAn> result = new List<BenhAn>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _BenhAnService.GetByYear_Month_Day_SearchStringToListAsync(baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.Day.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByBenhNhan_Id_Year_Month_DayToListAsync")]
        public virtual async Task<List<BenhAn>> GetByBenhNhan_Id_Year_Month_DayToListAsync()
        {
            List<BenhAn> result = new List<BenhAn>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _BenhAnService.GetByBenhNhan_Id_Year_Month_DayToListAsync(baseParameter.BenhNhan_Id.Value, baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.Day.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}


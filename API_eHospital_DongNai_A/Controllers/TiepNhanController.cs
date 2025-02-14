namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TiepNhanController : BaseController<TiepNhan, ITiepNhanService>
    {
        private readonly ITiepNhanService _TiepNhanService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public TiepNhanController(ITiepNhanService TiepNhanService, IWebHostEnvironment WebHostEnvironment) : base(TiepNhanService, WebHostEnvironment)
        {
            _TiepNhanService = TiepNhanService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByTiepNhan_IdAsync")]
        public virtual async Task<TiepNhan> GetByTiepNhan_IdAsync()
        {
            TiepNhan result = new TiepNhan();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _TiepNhanService.GetByTiepNhan_IdAsync(baseParameter.TiepNhan_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByNgayTiepNhan_SearchStringToListAsync")]
        public virtual async Task<List<TiepNhan>> GetByNgayTiepNhan_SearchStringToListAsync()
        {
            List<TiepNhan> result = new List<TiepNhan>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _TiepNhanService.GetByNgayTiepNhan_SearchStringToListAsync(baseParameter.NgayTiepNhan.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByYear_Month_Day_SearchStringToListAsync")]
        public virtual async Task<List<TiepNhan>> GetByYear_Month_Day_SearchStringToListAsync()
        {
            List<TiepNhan> result = new List<TiepNhan>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _TiepNhanService.GetByYear_Month_Day_SearchStringToListAsync(baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.Day.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}


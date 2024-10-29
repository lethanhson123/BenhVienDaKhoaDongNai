namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CongViecController : BaseController<CongViec, ICongViecService>
    {
        private readonly ICongViecService _CongViecService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public CongViecController(ICongViecService CongViecService, IWebHostEnvironment WebHostEnvironment) : base(CongViecService, WebHostEnvironment)
        {
            _CongViecService = CongViecService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetBySearchString_BatDau_KetThucToListAsync")]
        public async Task<List<CongViec>> GetBySearchString_BatDau_KetThucToListAsync()
        {
            List<CongViec> result = new List<CongViec>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _CongViecService.GetBySearchString_BatDau_KetThucToListAsync(model.SearchString, model.BatDau.Value, model.KetThuc.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }       
        [HttpPost]
        [Route("GetByThanhVienID001ToListAsync")]
        public async Task<List<CongViec>> GetByThanhVienID001ToListAsync()
        {
            List<CongViec> result = new List<CongViec>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _CongViecService.GetByThanhVienID001ToListAsync(model.ThanhVienID.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByThanhVienID002ToListAsync")]
        public async Task<List<CongViec>> GetByThanhVienID002ToListAsync()
        {
            List<CongViec> result = new List<CongViec>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _CongViecService.GetByThanhVienID002ToListAsync(model.ThanhVienID.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}


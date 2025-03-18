namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class GoiSoController : BaseController<GoiSo, IGoiSoService>
    {
        private readonly IGoiSoService _GoiSoService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public GoiSoController(IGoiSoService GoiSoService, IWebHostEnvironment WebHostEnvironment) : base(GoiSoService, WebHostEnvironment)
        {
            _GoiSoService = GoiSoService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GoiSoTiepTheoAsync")]
        public virtual async Task<GoiSo> UpdateByDanhMucGoiSoTiepTheoAsyncDichVuID_SoHienTaiAsync()
        {
            GoiSo result = new GoiSo();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoService.GoiSoTiepTheoAsync(baseParameter.DanhMucDichVuID.Value, baseParameter.SoHienTai.Value, baseParameter.DanhMucQuayDichVuID.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
        [HttpPost]
        [Route("SaveByDanhMucDichVuIDAsync")]
        public virtual async Task<GoiSo> SaveByDanhMucDichVuIDAsync()
        {
            GoiSo result = new GoiSo();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoService.SaveByDanhMucDichVuIDAsync(baseParameter.DanhMucDichVuID.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
        [HttpPost]
        [Route("CreateHTMLByModelAsync")]
        public async Task<GoiSo> CreateHTMLByModelAsync()
        {
            GoiSo result = new GoiSo();
            try
            {
                result = JsonConvert.DeserializeObject<GoiSo>(Request.Form["data"]);
                result = await _GoiSoService.CreateHTMLByModelAsync(result);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByNgayGhiNhanToListAsync")]
        public async Task<List<GoiSo>> GetByNgayGhiNhanToListAsync()
        {
            List<GoiSo> result = new List<GoiSo>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoService.GetByNgayGhiNhanToListAsync(baseParameter.KetThuc.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByYear_Month_DayToListAsync")]
        public async Task<List<GoiSo>> GetByYear_Month_DayToListAsync()
        {
            List<GoiSo> result = new List<GoiSo>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoService.GetByYear_Month_DayToListAsync(baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.Day.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("Sync_eHospital_DongNai_AAsync")]
        public virtual async Task<int> Sync_eHospital_DongNai_AAsync()
        {
            int result = GlobalHelper.InitializationNumber;
            try
            {
                result = await _GoiSoService.Sync_eHospital_DongNai_AAsync();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}


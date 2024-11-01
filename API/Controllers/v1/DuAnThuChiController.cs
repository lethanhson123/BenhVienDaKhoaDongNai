namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuAnThuChiController : BaseController<DuAnThuChi, IDuAnThuChiService>
    {
        private readonly IDuAnThuChiService _DuAnThuChiService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DuAnThuChiController(IDuAnThuChiService DuAnThuChiService, IWebHostEnvironment WebHostEnvironment) : base(DuAnThuChiService, WebHostEnvironment)
        {
            _DuAnThuChiService = DuAnThuChiService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetSQLByCodeToListAsync")]
        public async Task<List<DuAnThuChi>> GetSQLByCodeToListAsync()
        {
            List<DuAnThuChi> result = new List<DuAnThuChi>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DuAnThuChiService.GetSQLByCodeToListAsync(model.Code);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetBySoQuyetDinhToListAsync")]
        public async Task<List<DuAnThuChi>> GetBySoQuyetDinhToListAsync()
        {
            List<DuAnThuChi> result = new List<DuAnThuChi>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DuAnThuChiService.GetBySoQuyetDinhToListAsync(model.SoQuyetDinh);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}


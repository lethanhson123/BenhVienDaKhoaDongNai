namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuAnQuyetToanPhanKyController : BaseController<DuAnQuyetToanPhanKy, IDuAnQuyetToanPhanKyService>
    {
        private readonly IDuAnQuyetToanPhanKyService _DuAnQuyetToanPhanKyService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DuAnQuyetToanPhanKyController(IDuAnQuyetToanPhanKyService DuAnQuyetToanPhanKyService, IWebHostEnvironment WebHostEnvironment) : base(DuAnQuyetToanPhanKyService, WebHostEnvironment)
        {
            _DuAnQuyetToanPhanKyService = DuAnQuyetToanPhanKyService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetBySoQuyetDinhToListAsync")]
        public async Task<List<DuAnQuyetToanPhanKy>> GetBySoQuyetDinhToListAsync()
        {
            List<DuAnQuyetToanPhanKy> result = new List<DuAnQuyetToanPhanKy>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DuAnQuyetToanPhanKyService.GetBySoQuyetDinhToListAsync(model.SoQuyetDinh);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetSQLBySoQuyetDinhToListAsync")]
        public async Task<List<DuAnQuyetToanPhanKy>> GetSQLBySoQuyetDinhToListAsync()
        {
            List<DuAnQuyetToanPhanKy> result = new List<DuAnQuyetToanPhanKy>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DuAnQuyetToanPhanKyService.GetSQLBySoQuyetDinhToListAsync(model.SoQuyetDinh);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetSQLByDuAnQuyetDinhIDToListAsync")]
        public async Task<List<DuAnQuyetToanPhanKy>> GetSQLByDuAnQuyetDinhIDToListAsync()
        {
            List<DuAnQuyetToanPhanKy> result = new List<DuAnQuyetToanPhanKy>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DuAnQuyetToanPhanKyService.GetSQLByDuAnQuyetDinhIDToListAsync(model.DuAnQuyetDinhID.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetSQLByParentIDToListAsync")]
        public async Task<List<DuAnQuyetToanPhanKy>> GetSQLByParentIDToListAsync()
        {
            List<DuAnQuyetToanPhanKy> result = new List<DuAnQuyetToanPhanKy>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DuAnQuyetToanPhanKyService.GetSQLByParentIDToListAsync(model.ParentID.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}


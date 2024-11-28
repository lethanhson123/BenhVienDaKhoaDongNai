namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuAnQuyetToanLuyKeController : BaseController<DuAnQuyetToanLuyKe, IDuAnQuyetToanLuyKeService>
    {
        private readonly IDuAnQuyetToanLuyKeService _DuAnQuyetToanLuyKeService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DuAnQuyetToanLuyKeController(IDuAnQuyetToanLuyKeService DuAnQuyetToanLuyKeService, IWebHostEnvironment WebHostEnvironment) : base(DuAnQuyetToanLuyKeService, WebHostEnvironment)
        {
            _DuAnQuyetToanLuyKeService = DuAnQuyetToanLuyKeService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetBySoQuyetDinhToListAsync")]
        public async Task<List<DuAnQuyetToanLuyKe>> GetBySoQuyetDinhToListAsync()
        {
            List<DuAnQuyetToanLuyKe> result = new List<DuAnQuyetToanLuyKe>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DuAnQuyetToanLuyKeService.GetBySoQuyetDinhToListAsync(model.SoQuyetDinh);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetSQLBySoQuyetDinhToListAsync")]
        public async Task<List<DuAnQuyetToanLuyKe>> GetSQLBySoQuyetDinhToListAsync()
        {
            List<DuAnQuyetToanLuyKe> result = new List<DuAnQuyetToanLuyKe>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DuAnQuyetToanLuyKeService.GetSQLBySoQuyetDinhToListAsync(model.SoQuyetDinh);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetSQLByParentIDToListAsync")]
        public async Task<List<DuAnQuyetToanLuyKe>> GetSQLByParentIDToListAsync()
        {
            List<DuAnQuyetToanLuyKe> result = new List<DuAnQuyetToanLuyKe>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DuAnQuyetToanLuyKeService.GetSQLByParentIDToListAsync(model.ParentID.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}


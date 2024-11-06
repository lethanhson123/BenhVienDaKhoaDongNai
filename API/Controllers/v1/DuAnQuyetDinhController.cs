namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuAnQuyetDinhController : BaseController<DuAnQuyetDinh, IDuAnQuyetDinhService>
    {
        private readonly IDuAnQuyetDinhService _DuAnQuyetDinhService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DuAnQuyetDinhController(IDuAnQuyetDinhService DuAnQuyetDinhService, IWebHostEnvironment WebHostEnvironment) : base(DuAnQuyetDinhService, WebHostEnvironment)
        {
            _DuAnQuyetDinhService = DuAnQuyetDinhService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetSQLByThanhVienIDToListAsync")]
        public async Task<List<DuAnQuyetDinh>> GetSQLByThanhVienIDToListAsync()
        {
            List<DuAnQuyetDinh> result = new List<DuAnQuyetDinh>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DuAnQuyetDinhService.GetSQLByThanhVienIDToListAsync(model.ThanhVienID.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}


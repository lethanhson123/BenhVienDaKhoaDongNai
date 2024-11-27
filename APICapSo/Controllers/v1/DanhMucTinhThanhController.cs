namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucTinhThanhController : BaseController<DanhMucTinhThanh, IDanhMucTinhThanhService>
    {
        private readonly IDanhMucTinhThanhService _DanhMucTinhThanhService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucTinhThanhController(IDanhMucTinhThanhService DanhMucTinhThanhService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucTinhThanhService, WebHostEnvironment)
        {
            _DanhMucTinhThanhService = DanhMucTinhThanhService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetAllToListAsync")]
        public virtual async Task<List<DanhMucTinhThanh>> GetAllToListAsync()
        {
            List<DanhMucTinhThanh> result = new List<DanhMucTinhThanh>();
            try
            {
                result = await _DanhMucTinhThanhService.GetAllToListAsync();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByActiveToListAsync")]
        public virtual async Task<List<DanhMucTinhThanh>> GetByActiveToListAsync()
        {
            List<DanhMucTinhThanh> result = new List<DanhMucTinhThanh>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucTinhThanhService.GetByActiveToListAsync(baseParameter.Active.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}


namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucQuayDichVuController : BaseController<DanhMucQuayDichVu, IDanhMucQuayDichVuService>
    {
        private readonly IDanhMucQuayDichVuService _DanhMucQuayDichVuService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucQuayDichVuController(IDanhMucQuayDichVuService DanhMucQuayDichVuService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucQuayDichVuService, WebHostEnvironment)
        {
            _DanhMucQuayDichVuService = DanhMucQuayDichVuService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetAllToListAsync")]
        public virtual async Task<List<DanhMucQuayDichVu>> GetAllToListAsync()
        {
            List<DanhMucQuayDichVu> result = new List<DanhMucQuayDichVu>();
            try
            {
                result = await _DanhMucQuayDichVuService.GetAllToListAsync();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByActiveToListAsync")]
        public virtual async Task<List<DanhMucQuayDichVu>> GetByActiveToListAsync()
        {
            List<DanhMucQuayDichVu> result = new List<DanhMucQuayDichVu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucQuayDichVuService.GetByActiveToListAsync(baseParameter.Active.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}


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
        [Route("KhoiPhucAsync")]
        public virtual async Task<List<DanhMucQuayDichVu>> KhoiPhucAsync()
        {
            List<DanhMucQuayDichVu> result = new List<DanhMucQuayDichVu>();
            try
            {
                result = await _DanhMucQuayDichVuService.KhoiPhucAsync();
                foreach (DanhMucQuayDichVu item in result)
                {
                    await _DanhMucQuayDichVuService.SaveAsync(item);
                    result.Add(item);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}


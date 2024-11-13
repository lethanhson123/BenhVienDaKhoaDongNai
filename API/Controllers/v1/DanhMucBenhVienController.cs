namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucBenhVienController : BaseController<DanhMucBenhVien, IDanhMucBenhVienService>
    {
        private readonly IDanhMucBenhVienService _DanhMucBenhVienService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucBenhVienController(IDanhMucBenhVienService DanhMucBenhVienService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucBenhVienService, WebHostEnvironment)
        {
            _DanhMucBenhVienService = DanhMucBenhVienService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetAll001ToListAsync")]
        public virtual async Task<List<DanhMucBenhVien>> GetAll001ToListAsync()
        {
            List<DanhMucBenhVien> result = new List<DanhMucBenhVien>();
            try
            {
                result = await _DanhMucBenhVienService.GetAllToListAsync();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

